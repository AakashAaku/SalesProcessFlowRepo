using DSP.Core.Interfaces;
using DSP.Core.Interfaces.Purchase;
using DSP.Core.Services;
using DSP.Core.Services.Purchase;
using DSP.Data.Repositories;
using DSP.Domain.Interfaces;
using DSP.Domain.Interfaces.Purchase;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.DependencyContainer
{
    public class InjectionContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IVendorCustomersService, VendorCustomersServices>();
            services.AddScoped<IVendorCustomersRepository, VendorCustomersRepository>();

            services.AddScoped<ILicenseService, LicenseService>();
            services.AddScoped<ILicenseRepository, LicenseRepository>();

            services.AddScoped<IITN_OPROService, ITN_OPROService>();
            services.AddScoped<IITN_OPRORepository, ITN_OPRORepository>();
            //services.AddScoped<IdentityUser, ApplicationUser>();

            services.AddScoped<IInOutPaymentRepository, InOutPaymentRepository>();
            services.AddScoped<IInOutPaymentService, InOutPaymentService>();

            services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
            services.AddScoped<IPurchaseReturnRepository, PurchaseRetrunRepository>();
            services.AddScoped<IPurchaseInvoiceRepository, PurchaseInvoiceRepository>();

            services.AddScoped<IPurchaseOrderService, PurchaseOrderService>();
            services.AddScoped<IPurchaseInvoiceService, PurchaseInvoiceService>();
            services.AddScoped<IPurchaseReturnService, PurchaseReturnService>();


            services.AddScoped<IStockReceiptService, StockReceiptService>();
            services.AddScoped<IStockReceiptRepository, StockReceiptRepository>();

            services.AddScoped<IStockReturnService, StockReturnService>();
            services.AddScoped<IStockReturnRepository, StockReturnRepository>();
        }
    }
}
