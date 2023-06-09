﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace udiGrupal
{
    class Acceso
    {
        private OleDbConnection conexion;
        private OleDbCommand comando;
        private string stringConexion;


        public Acceso(string stringconexion)
        {
            conexion = new OleDbConnection(stringconexion);
            comando = new OleDbCommand();
            stringConexion = stringconexion;
        }

        public void Conectar(){
            conexion.ConnectionString = stringConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;

        }


        public void Desconectar() {
            conexion.Close();
            conexion.Dispose();
        }

        public DataTable ConsultaLectura(string comandoCompleto) {
            DataTable tablaResultado = new DataTable();
            Conectar();
            comando.CommandText=comandoCompleto;
            tablaResultado.Load(comando.ExecuteReader());
            Desconectar();
            return tablaResultado;
        }

        public void ConsultaEscritura(string comandoCompleto) {
            Conectar();
            comando.CommandText = comandoCompleto;
            comando.ExecuteNonQuery();
            Desconectar();
        }


    }
}