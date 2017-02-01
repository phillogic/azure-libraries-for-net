// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.AppService.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using AppServiceCertificateOrder.Definition;
    using Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions;
    using Resource.Fluent.Core;

    /// <summary>
    /// Entry point for app service certificate order management API.
    /// </summary>
    public interface IAppServiceCertificateOrders  :
        ISupportsCreating<IBlank>,
        ISupportsDeletingById,
        ISupportsListingByGroup<IAppServiceCertificateOrder>,
        ISupportsGettingByGroup<IAppServiceCertificateOrder>,
        ISupportsGettingById<IAppServiceCertificateOrder>,
        ISupportsDeletingByGroup,
        IHasManager<IAppServiceManager>
    {
    }
}