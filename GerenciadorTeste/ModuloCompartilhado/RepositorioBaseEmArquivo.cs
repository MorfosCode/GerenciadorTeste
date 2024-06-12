using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GerenciadorTeste.ModuloCompartilhado
{
    public class RepositorioBaseEmArquivo<T> where T : EntidadeBase
    {
        protected List<T> registros = new List<T>();
        protected int contadorId = 1;
        private string caminho = string.Empty;

        #region Construtor de classe
        public RepositorioBaseEmArquivo(string nomeArquivo)
        {
            caminho = $"C:\\gTestes\\repositorio\\{nomeArquivo}";

            registros = DeserializarRegistros();

            if(registros.Count > 0)
                contadorId = registros.Max(x => x.Id) + 1;
        }
        #endregion

        #region Cadastra entidade
        public void Cadastrar(T novoRegistro)
        {
            novoRegistro.Id = contadorId ++;
            
            registros.Add(novoRegistro);

            SerializarRegistros();
        }
        #endregion

        #region Cadastra várias entidades de uma lista para facilitar os testes
        public void CadastrarVarios(List<T> registrosAdicionados)
        {
            foreach(T registro in registrosAdicionados)
            {
                registro.Id = contadorId ++;
                registros.Add(registro);

                SerializarRegistros();
            }
        }
        #endregion

        #region Edita registro de entidade
        public bool Editar(int id, T novoRegistro)
        {
            T registro = SelecionarPorId(id);

            if (registro == null)
                return false;

            registro.AtualizarRegistro(novoRegistro);

            SerializarRegistros();

            return true;
        }
        #endregion

        #region Exclui um registro de entidade
        public bool Excluir(int id)
        {
            bool conseguiuExcluir = registros.Remove(SelecionarPorId(id));

            if(!conseguiuExcluir)
                return false;

            SerializarRegistros();

            return true;
        }
        #endregion

        #region Seleciona todos os registros e retorna em uma lista
        public List<T> SelecionarTodos()
        {
            return registros;
        }
        #endregion

        #region Seleciona entidade registrada por um id
        public T SelecionarPorId(int id)
        {
            return registros.Find(x => x.Id == id);
        }
        #endregion

        #region Consulta se existe um registro com um determinado id
        public bool Existe(int id)
        {
            return registros.Any(x => x.Id == id);
        }
        #endregion

        #region Serealiza registros para arquivo
        private void SerializarRegistros()
        {
            FileInfo arquivo = new FileInfo(caminho);
            arquivo.Directory.Create();
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };
            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(registros, options);
            File.WriteAllBytes(caminho, registrosEmBytes);
        }
        #endregion

        #region Deserealiza registros de um arquivo
        private List<T> DeserializarRegistros()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return new List<T>();

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            List<T> registros = JsonSerializer.Deserialize<List<T>>(registrosEmBytes, options);

            return registros;
        }
        #endregion
    }
}
