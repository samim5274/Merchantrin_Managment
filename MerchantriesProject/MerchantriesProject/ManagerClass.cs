using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantriesProject
{
    public class ManagerClass
    {
        internal List<SP_CATEGORY_SHOW_Result> GettCategory()
        {
            var context = new MerchantriesEntities();
            var q = context.SP_CATEGORY_SHOW();
            return q.ToList();
        }

        internal List<SP_MENUFACTURE_SHOW_Result> GetManufacture()
        {
            var context = new MerchantriesEntities();
            var q = context.SP_MENUFACTURE_SHOW();
            return q.ToList();
        }

        internal List<SP_PRODUCT_DETAIL_SHOW_Result> GetProductDetail()
        {
            var context = new MerchantriesEntities();
            var q = context.SP_PRODUCT_DETAIL_SHOW();
            return q.ToList();
        }

        internal List<SP_USERDETAIL_Result> GetAllUser()
        {
            var context = new MerchantriesEntities();
            var q = context.SP_USERDETAIL();
            return q.ToList();
        }

        internal List<SP_SALES_INFO_SHOW_Result> GetAllSalesInfo()
        {
            var context = new MerchantriesEntities();
            var q = context.SP_SALES_INFO_SHOW();
            return q.ToList();
        }

        internal object GetAllProduct()
        {
            var context = new MerchantriesEntities();
            var q = from Sem in context.ProductDetails select Sem;
            return q.ToList();
        }
    }
}
