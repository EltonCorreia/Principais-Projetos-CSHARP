﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


    public class ClasseConexao
    {
        /*Classe para conexäo com DB*/
		
		/*Para utilizar futuramente mude o "Initial Catalog=Teste" para o nome do seu banco e retire o "\\SQLEXPRESS"*/

        SqlConnection conexao = new SqlConnection();

        public SqlConnection conectar(){
            try{
                String strConexao = "Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=Teste; Data Source=" + Environment.MachineName + "\\SQLEXPRESS";
                conexao.ConnectionString = strConexao;
                conexao.Open();
                return conexao;
            }catch (Exception){
                desconectar();
                return null;
            }
        }

        public void desconectar(){
            try{
                if ((conexao.State == ConnectionState.Open)){
                    conexao.Close();
                    conexao.Dispose();
                    conexao = null;
                }
            }catch (Exception) { }
        }

        public DataTable executarSQL(String comando_sql){
            try{
                conectar();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conexao);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                return ds.Tables[0];
            }catch (Exception){
                return null;
            }finally{
                desconectar();
            }
        }

        public bool manutencaoDB(String comando_sql) //incluir, alterar, excluir
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = comando_sql;
                comando.Connection = conexao;
                comando.ExecuteScalar();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                desconectar();
            }
        }//fim do método manutençãoDB

        public int manutencaoDB_Parametros(SqlCommand comando) //incluir, alterar, excluir com parâmetros
        {
            int retorno = 0;
            try
            {
                comando.Connection = conectar();  //adiciona a conexão ao SQLCommand
                retorno = comando.ExecuteNonQuery(); //devolve o número de linhas afetadas no banco
            }
            catch (Exception) { }
            desconectar();
            return retorno;
        }//fim do método manutençãoDB com parâmetros

    }//fim da classeConexao

