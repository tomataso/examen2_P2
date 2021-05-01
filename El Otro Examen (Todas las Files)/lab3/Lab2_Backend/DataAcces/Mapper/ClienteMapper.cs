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
    class ClienteMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_CEDULA = "cedula";
        private const string DB_COL_NOMBRE = "nombre";
        private const string DB_COL_APELLIDO = "apellido";
        private const string DB_COL_FECHA_NACIMIENTO = "fecha_nacimiento";
        private const string DB_COL_EDAD = "edad";
        private const string DB_COL_ESTADO_CIVIL = "estado_civil";
        private const string DB_COL_GENERO = "genero";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            // ACORDARSE PONER EL PROCEDIMIENTO ALMACENADO ACA.
            var operation = new SqlOperation { ProcedureName = "CREATE_CLIENTE_PR" };

            var c = (Cliente)entity;
            operation.AddVarcharParam(DB_COL_CEDULA, c.cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE, c.nombre);
            operation.AddVarcharParam(DB_COL_APELLIDO, c.apellido);
            operation.AddParam(DB_COL_FECHA_NACIMIENTO, c.fecha_nacimiento);
            operation.AddIntParam(DB_COL_EDAD, c.edad);
            operation.AddVarcharParam(DB_COL_ESTADO_CIVIL, c.estado_civil);
            operation.AddVarcharParam(DB_COL_GENERO, c.genero);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CLIENTE_PR" };

            var c = (Cliente)entity;
            operation.AddVarcharParam(DB_COL_CEDULA, c.cedula);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CLIENTES_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CLIENTE_PR" };

            var c = (Cliente)entity;
            operation.AddVarcharParam(DB_COL_CEDULA, c.cedula);
            operation.AddVarcharParam(DB_COL_NOMBRE, c.nombre);
            operation.AddVarcharParam(DB_COL_APELLIDO, c.apellido);
            operation.AddParam(DB_COL_FECHA_NACIMIENTO, c.fecha_nacimiento);
            operation.AddIntParam(DB_COL_EDAD, c.edad);
            operation.AddVarcharParam(DB_COL_ESTADO_CIVIL, c.estado_civil);
            operation.AddVarcharParam(DB_COL_GENERO, c.genero);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CLIENTE_PR" };

            var c = (Cliente)entity;
            operation.AddVarcharParam(DB_COL_CEDULA, c.cedula);
            return operation;
        }

        // Devuelve lista de todo lo que trae la base de datos.
        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var cliente = BuildObject(row);
                lstResults.Add(cliente);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var cliente = new Cliente
            {
                cedula = GetStringValue(row, DB_COL_CEDULA),
                nombre = GetStringValue(row, DB_COL_NOMBRE),
                apellido = GetStringValue(row, DB_COL_APELLIDO),
                fecha_nacimiento = GetDateValue(row, DB_COL_FECHA_NACIMIENTO),
                edad = GetIntValue(row, DB_COL_EDAD),
                estado_civil = GetStringValue(row, DB_COL_ESTADO_CIVIL),
                genero = GetStringValue(row, DB_COL_GENERO)
            };

            return cliente;
        }

 

        SqlOperation ISqlStaments.GetRetriveAllStatement()
        {
            throw new NotImplementedException();
        }

    }
}