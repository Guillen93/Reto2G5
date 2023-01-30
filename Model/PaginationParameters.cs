namespace Reto2G5.Model
{
    public class PaginationParameters
    {
        public int PageNumber { get; set; } = 1;
        //numero de pagina seleccionada, en la que estoy
        public int PageSize { get; set; } = 10;
        //cuantos pokemon vamos a tener por página
        public int Offset => (PageNumber - 1) * PageSize;
        //posición desde la que se tiene que empezar a coger pokemons
        //traeremos el numero PageSize de pokemons
        //GET: Realiza la operacion (PageNumber - 1) * PageSize y se le asigna a Offset
    }
}
