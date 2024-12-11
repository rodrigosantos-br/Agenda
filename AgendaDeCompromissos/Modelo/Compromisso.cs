namespace AgendaDeCompromissos.Modelo
{
    internal class Compromisso
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataHora { get; set; }
        public string Descricao { get; set; }
    }
}
