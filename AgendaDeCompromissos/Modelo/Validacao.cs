namespace AgendaDeCompromissos.Modelo
{
    internal class Validacao
    {
        public List<string> ValidarCompromisso(string titulo, DateTime dataHora, string descricao)
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(titulo))
                erros.Add("O título do compromisso não pode ser vazio ou nulo.");
            if (titulo.Length > 50)
                erros.Add("O título do compromisso não pode ter mais de 50 caracteres.");

            if (dataHora < DateTime.Now)
                erros.Add("A data e hora do compromisso não pode estar no passado.");

            if (string.IsNullOrWhiteSpace(descricao))
                erros.Add("A descrição do compromisso não pode ser vazia ou nula.");
            if (descricao.Length > 200)
                erros.Add("A descrição do compromisso não pode ter mais de 200 caracteres.");

            return erros;
        }

    }
}
