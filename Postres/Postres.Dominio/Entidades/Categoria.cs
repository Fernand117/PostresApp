﻿namespace Postres.Dominio.Entidades
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string UrlFoto { get; set; } = string.Empty;
    }
}
