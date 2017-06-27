// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Network.Fluent
{
    using Models;
    using ResourceManager.Fluent.Core;
    using Rest.Azure;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Implementation for NetworkSecurityGroups.
    /// </summary>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50Lm5ldHdvcmsuaW1wbGVtZW50YXRpb24uTmV0d29ya1NlY3VyaXR5R3JvdXBzSW1wbA==
    internal partial class NetworkSecurityGroupsImpl  :
        TopLevelModifiableResources<
            INetworkSecurityGroup,
            NetworkSecurityGroupImpl,
            NetworkSecurityGroupInner,
            INetworkSecurityGroupsOperations,
            INetworkManager>,
        INetworkSecurityGroups
    {
        ///GENMHASH:0181826DACC9044D90EB575AAA5C527E:51C34340BDCC9750108D6EDBB1DD1BA7
        internal  NetworkSecurityGroupsImpl (INetworkManager networkManager) : base(networkManager.Inner.NetworkSecurityGroups, networkManager)
        {
        }

        ///GENMHASH:7D6013E8B95E991005ED921F493EFCE4:36E25639805611CF89054C004B22BB15
        protected async override Task<IPage<NetworkSecurityGroupInner>> ListInnerAsync(CancellationToken cancellationToken)
        {
            return await Inner.ListAllAsync(cancellationToken);
        }

        protected async override Task<IPage<NetworkSecurityGroupInner>> ListInnerNextAsync(string nextLink, CancellationToken cancellationToken)
        {
            return await Inner.ListAllNextAsync(nextLink, cancellationToken);
        }

        ///GENMHASH:95834C6C7DA388E666B705A62A7D02BF:3953AC722DFFCDF40E1EEF787AFD1326
        protected async override Task<IPage<NetworkSecurityGroupInner>> ListInnerByGroupAsync(string groupName, CancellationToken cancellationToken)
        {
            return await Inner.ListAsync(groupName, cancellationToken);
        }

        protected async override Task<IPage<NetworkSecurityGroupInner>> ListInnerByGroupNextAsync(string nextLink, CancellationToken cancellationToken)
        {
            return await Inner.ListNextAsync(nextLink, cancellationToken);
        }

        ///GENMHASH:8ACFB0E23F5F24AD384313679B65F404:AD7C28D26EC1F237B93E54AD31899691
        internal NetworkSecurityGroupImpl Define (string name)
        {
            return WrapModel(name);
        }

        ///GENMHASH:0679DF8CA692D1AC80FC21655835E678:B9B028D620AC932FDF66D2783E476B0D
        public async override Task DeleteByResourceGroupAsync(string groupName, string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Clear NIC references if any
            var nsg = await GetByResourceGroupAsync(groupName, name, cancellationToken);
            if (nsg != null)
            {
                var nicIds = nsg.NetworkInterfaceIds;
                if (nicIds != null)
                {
                    foreach (string nicRef in nicIds)
                    {
                        var nic = await Manager.NetworkInterfaces.GetByIdAsync(nicRef, cancellationToken);
                        if (nic == null)
                        {
                            continue;
                        }
                        else if (!nsg.Id.ToLowerInvariant().Equals(nic.NetworkSecurityGroupId.ToLowerInvariant()))
                        {
                            continue;
                        }
                        else
                        {
                            await nic.Update().WithoutNetworkSecurityGroup().ApplyAsync(cancellationToken);
                        }
                    }
                }
            }

            await DeleteInnerByGroupAsync(groupName, name, cancellationToken);
        }
        protected async override Task DeleteInnerByGroupAsync(string groupName, string name, CancellationToken cancellationToken)
        {
            await Inner.DeleteAsync(groupName, name, cancellationToken);
        }

        ///GENMHASH:AB63F782DA5B8D22523A284DAD664D17:7C0A1D0C3FE28C45F35B565F4AFF751D
        protected async override Task<NetworkSecurityGroupInner> GetInnerByGroupAsync(string groupName, string name, CancellationToken cancellationToken)
        {
            return await Inner.GetAsync(groupName, name, cancellationToken: cancellationToken);
        }

        ///GENMHASH:2FE8C4C2D5EAD7E37787838DE0B47D92:270930AE3F3A3D55E769C7D1E06A71C2
        override protected NetworkSecurityGroupImpl WrapModel (string name)
        {
            NetworkSecurityGroupInner inner = new NetworkSecurityGroupInner();
            return new NetworkSecurityGroupImpl(name, inner, Manager);
        }

        //$TODO: return NetworkSecurityGroupImpl

        ///GENMHASH:B59141AC50BFD765AA31B7D8EBE354C5:DBC6065F28483C4BE88514804CCBFFAA
        override protected INetworkSecurityGroup WrapModel (NetworkSecurityGroupInner inner)
        {
            return new NetworkSecurityGroupImpl(inner.Name, inner, Manager);
        }
    }
}