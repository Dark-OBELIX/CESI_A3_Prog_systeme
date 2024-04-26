namespace classe
{
    public class Language_fr : LanguageBase
    {

        public override string set_lang()
        {
            return "Langue reglé sur français";
        }

        public override string choice_cut_copy()
        {
            return "Voulez vous COUPEZ ou COPIER le fichier initiale ?";
        }
        public override string validation_choice_cut()
        {
            return "Ok on va effacer le fichier original";
        }
        public override string validation_choice_copy()
        {
            return "Ok on va garder le fichier original";
        }
        public override string choice_stain_name()
        {
            return "Choisissez le nom de la sauvegarde";
        }
    }
}
