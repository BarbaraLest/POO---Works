namespace ExHeranca2.Entities
{
    class GeometricFigure
    {
        public string Form { get; set; }

        public GeometricFigure(string form)
        {
            Form = form;
        }

        public virtual string ShowGeo()
        {
            return Form;
        }
    }
}
