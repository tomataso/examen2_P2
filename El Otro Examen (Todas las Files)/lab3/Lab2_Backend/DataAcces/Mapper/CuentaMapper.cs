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
    class CuentaMapper : EntityMapper, ISqlStaments, IObjectMapper
    {

        private const string DB_COL_ID_CUENTA = "id_cuenta";

        private const string DB_COL_MONEDA = "moneda";
        private const string DB_COL_TIPO = "tipo";
        private const string DB_COL_SALDO = "saldo";
        private const string DB_COL_CLIENTE_ID = "cliente_id";

    


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            // ACORDARSE PONER EL PROCEDIMIENTO ALMACENADO ACA.
            var operation = new SqlOperation { ProcedureName = "CREATE_CUENTA_PR" };

            var c = (Cuenta)entity;

            operation.AddVarcharParam(DB_COL_MONEDA, c.moneda);
            operation.AddParam(DB_COL_TIPO, c.moneda);
            operation.AddParam(DB_COL_SALDO, c.saldo);
            operation.AddVarcharParam(DB_COL_CLIENTE_ID, c.cliente_id);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {

            // CUENTA POR ID DEL CUENTA
            var operation = new SqlOperation { ProcedureName = "RET_CUENTA_PR " };

            var c = (Cuenta)entity;
            operation.AddIntParam(DB_COL_ID_CUENTA, c.id_cuenta);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CUENTAS_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CUENTA_PR" };

            var c = (Cuenta)entity;

            operation.AddVarcharParam(DB_COL_MONEDA, c.moneda);
            operation.AddParam(DB_COL_TIPO, c.moneda);
            operation.AddParam(DB_COL_SALDO, c.saldo);
            operation.AddVarcharParam(DB_COL_CLIENTE_ID, c.cliente_id);

            operation.AddIntParam(DB_COL_ID_CUENTA, c.id_cuenta);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CUENTA_PR" };

            var c = (Cuenta)entity;
            operation.AddIntParam(DB_COL_ID_CUENTA, c.id_cuenta);
            return operation;
        }

        // Devuelve lista de todo lo que trae la base de datos.
        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var cuenta = BuildObject(row);
                lstResults.Add(cuenta);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var cuenta = new Cuenta
            {
                id_cuenta = GetIntValue(row, DB_COL_ID_CUENTA),
                moneda = GetStringValue(row, DB_COL_MONEDA),
                tipo = GetStringValue(row, DB_COL_TIPO),
                saldo = GetDecimalValue(row, DB_COL_SALDO),
                cliente_id = GetStringValue(row, DB_COL_CLIENTE_ID)
                
            };

            return cuenta;
        }



        SqlOperation ISqlStaments.GetRetriveAllStatement()
        {
            throw new NotImplementedException();
        }

    }
}
