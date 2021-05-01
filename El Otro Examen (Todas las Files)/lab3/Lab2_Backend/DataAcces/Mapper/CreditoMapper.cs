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
     class CreditoMapper : EntityMapper, ISqlStaments, IObjectMapper
    {

        private const string DB_COL_ID_CREDITO = "id_credito";
        private const string DB_COL_MONTO = "monto";
        private const string DB_COL_TASA = "tasa";
        private const string DB_COL_NOMBRE_LINEA = "nombre_linea";
        private const string DB_COL_CUOTA = "cuota";
        private const string DB_COL_FECHA_INICIO = "fecha_inicio";
        private const string DB_COL_ESTADO = "estado";
        private const string DB_COL_SALDO = "saldo";
        private const string DB_COL_CLIENTE_ID = "cliente_id";

        


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            // ACORDARSE PONER EL PROCEDIMIENTO ALMACENADO ACA.
            var operation = new SqlOperation { ProcedureName = "CREATE_CREDITO_PR" };

            var c = (Credito)entity;
            operation.AddParam(DB_COL_MONTO, c.monto);
            operation.AddParam(DB_COL_TASA, c.tasa);
            operation.AddVarcharParam(DB_COL_NOMBRE_LINEA, c.nombre_linea);
            operation.AddParam(DB_COL_CUOTA, c.cuota);
            operation.AddParam(DB_COL_FECHA_INICIO, c.fecha_inicio);
            operation.AddVarcharParam(DB_COL_ESTADO, c.estado);
            operation.AddParam(DB_COL_SALDO, c.saldo);
            operation.AddVarcharParam(DB_COL_CLIENTE_ID, c.cliente_id);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CREDITO_PR" };

            var c = (Credito)entity;
            operation.AddIntParam(DB_COL_ID_CREDITO, c.id_credito);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CREDITOS_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CREDITO_PR" };

            var c = (Credito)entity;
            operation.AddParam(DB_COL_MONTO, c.monto);
            operation.AddParam(DB_COL_TASA, c.tasa);
            operation.AddVarcharParam(DB_COL_NOMBRE_LINEA, c.nombre_linea);
            operation.AddParam(DB_COL_CUOTA, c.cuota);
            operation.AddParam(DB_COL_FECHA_INICIO, c.fecha_inicio);
            operation.AddVarcharParam(DB_COL_ESTADO, c.estado);
            operation.AddParam(DB_COL_SALDO, c.saldo);
            operation.AddVarcharParam(DB_COL_CLIENTE_ID, c.cliente_id);
            operation.AddIntParam(DB_COL_ID_CREDITO, c.id_credito);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CREDITO_PR" };

            var c = (Credito)entity;
            operation.AddIntParam(DB_COL_ID_CREDITO, c.id_credito);
            return operation;
        }

        // Devuelve lista de todo lo que trae la base de datos.
        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var creditos = BuildObject(row);
                lstResults.Add(creditos);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var credito = new Credito
            {
                id_credito = GetIntValue(row, DB_COL_ID_CREDITO),
                monto = GetDecimalValue(row, DB_COL_MONTO),
                tasa = GetDecimalValue(row, DB_COL_TASA),
                nombre_linea = GetStringValue(row, DB_COL_NOMBRE_LINEA),
                cuota = GetDecimalValue(row, DB_COL_CUOTA),
                fecha_inicio = GetDateValue(row, DB_COL_FECHA_INICIO),              
                estado = GetStringValue(row, DB_COL_ESTADO),
                saldo = GetDecimalValue(row, DB_COL_SALDO),
                cliente_id = GetStringValue(row, DB_COL_CLIENTE_ID)
                
            };

            return credito;
        }



        SqlOperation ISqlStaments.GetRetriveAllStatement()
        {
            throw new NotImplementedException();
        }

    }
}
