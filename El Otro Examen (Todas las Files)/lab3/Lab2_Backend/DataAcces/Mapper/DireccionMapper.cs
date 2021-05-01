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
    class DireccionMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID_DIRECCION = "id_direccion";

        private const string DB_COL_PROVINCIA = "provincia";
        private const string DB_COL_CANTON = "canton";
        private const string DB_COL_DISTRITO= "distrito";
        private const string DB_COL_DETALLES = "detalles";
        private const string DB_COL_CLIENTE_ID = "cliente_id";

        


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            // ACORDARSE PONER EL PROCEDIMIENTO ALMACENADO ACA.
            var operation = new SqlOperation { ProcedureName = "CREATE_DIRECCION_PR" };

            var c = (Direccion)entity;

            operation.AddVarcharParam(DB_COL_PROVINCIA, c.provincia);
            operation.AddVarcharParam(DB_COL_CANTON, c.canton);
            operation.AddVarcharParam(DB_COL_DISTRITO, c.distrito);
            operation.AddVarcharParam(DB_COL_DETALLES, c.detalles);
            operation.AddVarcharParam(DB_COL_CLIENTE_ID, c.cliente_id);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {

         
            var operation = new SqlOperation { ProcedureName = "RET_DIRECCION_PR" };

            var c = (Direccion)entity;
            operation.AddIntParam(DB_COL_ID_DIRECCION, c.id_direccion);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_DIRECCIONES_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {

            // Con la ID de dela dirección busca la dirección
            var operation = new SqlOperation { ProcedureName = "UPD_DIRECCION_PR" };

            var c = (Direccion)entity;

            operation.AddVarcharParam(DB_COL_PROVINCIA, c.provincia);
            operation.AddVarcharParam(DB_COL_CANTON, c.canton);
            operation.AddVarcharParam(DB_COL_DISTRITO, c.distrito);
            operation.AddVarcharParam(DB_COL_DETALLES, c.detalles);
            operation.AddVarcharParam(DB_COL_CLIENTE_ID, c.cliente_id);

            operation.AddIntParam(DB_COL_ID_DIRECCION, c.id_direccion);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_DIRECCION_PR" };

            var c = (Direccion)entity;
            operation.AddIntParam(DB_COL_ID_DIRECCION, c.id_direccion);
            return operation;
        }

        // Devuelve lista de todo lo que trae la base de datos.
        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var direccion = BuildObject(row);
                lstResults.Add(direccion);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var direccion = new Direccion
            {
                id_direccion = GetIntValue(row, DB_COL_ID_DIRECCION),
                provincia = GetStringValue(row, DB_COL_PROVINCIA),
                canton = GetStringValue(row, DB_COL_CANTON),
                distrito = GetStringValue(row, DB_COL_DISTRITO),
                detalles = GetStringValue(row, DB_COL_DETALLES),
                cliente_id = GetStringValue(row, DB_COL_CLIENTE_ID)
                
            };

            return direccion;
        }



        SqlOperation ISqlStaments.GetRetriveAllStatement()
        {
            throw new NotImplementedException();
        }

    }
}