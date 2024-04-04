using AutomatizacionDirecTv.ServicesDirecTV;
using AutomatizacionDirecTv.ServicesIntegracionDTV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionDirecTv
{
    class Program
    {
        static void Main(string[] args)
        {

            GetINT008();
            GetINT009();
            GetINT010();
            GetINT012();
            GetINT015a();
            GetINT015b();
            GetINT015c();
            GetINT038();

            GetAsnTeorico();
            GetAsnRecepcion();
            GetInventoryAdjustment();
            GetKittingWorkOrder();
            GetReturnOrder();
            GetSalesOrder();
            GetTransferOrder();
            GetTransferOrderDespatch();
            GetTransferOrderReceipt();
            GetStockOcasa();
            GetDirecTvErrors();
        }

        static void GetINT008()
        {
            INT008.GetINT008();
        }
        static void GetINT009()
        {
            INT009.GetINT009();
        }
        static void GetINT010()
        {
            INT010.GetINT010();
        }
        static void GetINT012()
        {
            INT012.GetINT012();
        }
        static void GetINT015a()
        {
            INT015a.GetINT015a();
        }
        static void GetINT015b()
        {
            INT015b.GetINT015b();
        }
        
        static void GetINT015c()
        {
            INT015c.GetINT015c();
        }
        static void GetINT038()
        {
            INT038.GetINT038();
        }
        static void GetAsnTeorico()
        {
            AsnTeoricoService.GetAsnTeorico();
        }
        static void GetAsnRecepcion()
        {
            AsnRecepcion.GetAsnRecepcion();
        }
        static void GetInventoryAdjustment()
        {
            InventoryAdjustment.GetInventoryAdjustment();
        }
        static void GetKittingWorkOrder()
        {
            KittingWorkOrder.GetKittingWorkOrder();
        }
        static void GetReturnOrder()
        {
            ReturnOrder.GetReturnOrder();
        }
        static void GetSalesOrder()
        {
            SalesOrder.GetSalesOrder();
        }
        static void GetTransferOrder()
        {
            TransferOrder.GetTRansferORder();
        }
        static void GetTransferOrderDespatch()
        {
            TransferOrderDespatch.GetTransferOrderDespatch();
        }
        static void GetTransferOrderReceipt()
        {
            TransferOrderReceipt.GetTransferOrderReceipt();
        }
        static void GetStockOcasa()
        {
            StockOcasa.GetStockOcasa();
        }
        static void GetDirecTvErrors()
        {
            BuscadorErrores.GetErroresDirecTv();
        }
    }
}
