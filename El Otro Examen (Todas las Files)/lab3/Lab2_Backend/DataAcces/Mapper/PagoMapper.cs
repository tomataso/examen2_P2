using DataAcess.Dao;
using DataAcess.Mapper;
using Entities_POJO;
using Lab3_Backend.Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Backend.DataAcces.Mapper
{
    class PagoMapper : EntityMapper, ISqlStaments, IObjectMapper
    {

        private const string DB_COL_ID_PAGO = "id_pago";

        private const string DB_COL_FECHA_PAGO = "fecha_pago";
        private const string DB_COL_MONTO = "monto";
        private const string DB_COL_CREDITO_ID = "credito_id";




        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            // ACORDARSE PONER EL PROCEDIMIENTO ALMACENADO ACA.
            var operation = new SqlOperation { ProcedureName = "CREATE_PAGO_PR" };

            var c = (Pago)entity;
            operation.AddParam(DB_COL_FECHA_PAGO, c.fecha_pago);
            operation.AddParam(DB_COL_MONTO, c.monto);

            operation.AddIntParam(DB_COL_CREDITO_ID, c.credito_id);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_PAGO_PR" };

            var c = (Pago)entity;
            operation.AddIntParam(DB_COL_ID_PAGO, c.id_pago);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_PAGOS_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_PAGO_PR" };

            var c = (Pago)entity;
            operation.AddParam(DB_COL_FECHA_PAGO, c.fecha_pago);
            operation.AddParam(DB_COL_MONTO, c.monto);
            operation.AddIntParam(DB_COL_CREDITO_ID, c.credito_id);

            operation.AddIntParam(DB_COL_ID_PAGO, c.id_pago);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_PAGO_PR" };

            var c = (Pago)entity;
            operation.AddIntParam(DB_COL_ID_PAGO, c.id_pago);
            return operation;
        }

        // Devuelve lista de todo lo que trae la base de datos.
        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var pago = BuildObject(row);
                lstResults.Add(pago);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var pago = new Pago
            {
                id_pago = GetIntValue(row, DB_COL_ID_PAGO),
                fecha_pago = GetDateValue(row, DB_COL_FECHA_PAGO),
                monto = GetDecimalValue(row, DB_COL_MONTO),
                credito_id = GetIntValue(row, DB_COL_CREDITO_ID),

            };

            return pago;
        }



        SqlOperation ISqlStaments.GetRetriveAllStatement()
        {
            throw new NotImplementedException();
        }

    }
}
