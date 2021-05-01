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
    class MovimientoMapper : EntityMapper, ISqlStaments, IObjectMapper
    {

        private const string DB_COL_ID_MOVIMIENTO = "id_movimiento";

        private const string DB_COL_FECHA_MOVIMIENTO = "fecha_movimiento";
        private const string DB_COL_TIPO = "tipo";
        private const string DB_COL_MONTO = "monto";
        private const string DB_COL_CUENTA_ID = "cuenta_id";




        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            // ACORDARSE PONER EL PROCEDIMIENTO ALMACENADO ACA.
            var operation = new SqlOperation { ProcedureName = "CREATE_MOVIMIENTO_PR" };

            var c = (Movimiento)entity;
            operation.AddParam(DB_COL_FECHA_MOVIMIENTO, c.fecha_movimiento);
            operation.AddVarcharParam(DB_COL_TIPO, c.tipo);
            operation.AddParam(DB_COL_MONTO, c.monto);
      

            operation.AddIntParam(DB_COL_CUENTA_ID, c.cuenta_id);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_MOVIMIENTO_PR " };

            var c = (Movimiento)entity;
            operation.AddIntParam(DB_COL_ID_MOVIMIENTO, c.id_movimiento);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_MOVIMIENTOS_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_MOVIMIENTO_PR" };

            var c = (Movimiento)entity;
            operation.AddParam(DB_COL_FECHA_MOVIMIENTO, c.fecha_movimiento);
            operation.AddVarcharParam(DB_COL_TIPO, c.tipo);
            operation.AddParam(DB_COL_MONTO, c.monto);
            operation.AddIntParam(DB_COL_CUENTA_ID, c.cuenta_id);
            operation.AddIntParam(DB_COL_ID_MOVIMIENTO, c.id_movimiento);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_MOVIMIENTO_PR" };

            var c = (Movimiento)entity;
            operation.AddIntParam(DB_COL_ID_MOVIMIENTO, c.id_movimiento);
            return operation;
        }

        // Devuelve lista de todo lo que trae la base de datos.
        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var movimiento = BuildObject(row);
                lstResults.Add(movimiento);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var movimiento = new Movimiento
            {
                id_movimiento = GetIntValue(row, DB_COL_ID_MOVIMIENTO),
                fecha_movimiento = GetDateValue(row, DB_COL_FECHA_MOVIMIENTO),
                tipo  = GetStringValue(row, DB_COL_TIPO),
                monto = GetDecimalValue(row, DB_COL_MONTO),
                cuenta_id = GetIntValue(row, DB_COL_CUENTA_ID),

            };

            return movimiento;
        }



        SqlOperation ISqlStaments.GetRetriveAllStatement()
        {
            throw new NotImplementedException();
        }

    }
}
