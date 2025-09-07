using MauiAppMinhasCompras.Models;
using SQLite;

namespace MauiAppMinhasCompras.Helpers
{
    public class SQLiteDatabaseHelper
    {
        // Conexão assíncrona com o banco de dados SQLite
        readonly SQLiteAsyncConnection _conn;

        // Construtor que inicializa a conexão e cria a tabela Produto se não existir
        public SQLiteDatabaseHelper(string path) 
        { 
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Produto>().Wait(); 
        }

        // Insere um novo produto
        public Task<int> Insert(Produto p) 
        {
            return _conn.InsertAsync(p);
        }

        // ✅ Atualiza um produto existente
        public Task<int> Update(Produto p) 
        {
            return _conn.UpdateAsync(p); // Usa o UpdateAsync do SQLite-net
        }

        // Deleta um produto pelo Id
        public Task<int> Delete(Produto p) 
        {
            return _conn.DeleteAsync(p);
        }

        // Retorna todos os produtos
        public Task<List<Produto>> GetAll() 
        {
            return _conn.Table<Produto>().ToListAsync();
        }

        // Pesquisa produtos pela descrição (parâmetro seguro)
        public Task<List<Produto>> Search(string q) 
        {
            string sql = "SELECT * FROM Produto WHERE Descricao LIKE ?";
            return _conn.QueryAsync<Produto>(sql, $"%{q}%");
        }

        internal async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
