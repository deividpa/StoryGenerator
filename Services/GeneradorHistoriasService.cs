using StoryGenerator.Models;
using System;
using System.Collections.Generic;

public class GeneradorHistoriasService
{
    private readonly Random _random = new Random();

    private readonly List<string> _generos = new List<string> { "Fantasía", "Ciencia Ficción", "Misterio", "Romance", "Aventura", "Terror" };
    private readonly List<string> _protagonistas = new List<string> { "un valiente caballero", "una científica brillante", "un detective astuto", "una artista soñadora", "un explorador intrépido" };
    private readonly List<string> _escenarios = new List<string> { "en un reino mágico", "en una estación espacial", "en una mansión antigua", "en una ciudad costera", "en una selva inexplorada" };
    private readonly List<string> _conflictos = new List<string> { "debe enfrentarse a un dragón", "descubre una conspiración", "resuelve un crimen misterioso", "encuentra el amor verdadero", "busca un tesoro legendario" };
    private readonly List<string> _resoluciones = new List<string> { "con coraje y determinación", "utilizando tecnología avanzada", "gracias a su inteligencia", "con el poder del amor", "con la ayuda de aliados inesperados" };

    public Historia GenerarHistoria(string genero)
    {
        return new Historia
        {
            Genero = genero,
            Protagonista = _protagonistas[_random.Next(_protagonistas.Count)],
            Escenario = _escenarios[_random.Next(_escenarios.Count)],
            Conflicto = _conflictos[_random.Next(_conflictos.Count)],
            Resolucion = _resoluciones[_random.Next(_resoluciones.Count)]
        };
    }

    public List<string> ObtenerGeneros() => _generos;
}