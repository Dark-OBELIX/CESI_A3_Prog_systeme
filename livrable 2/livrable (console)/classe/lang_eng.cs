namespace classe
{
    public class Language_eng : LanguageBase
    {

        public override string set_lang()
        {
            return "Language set to english";
        }
        public override string choice_cut_copy()
        {
            return "Do you want to COPY or CUT the file ? ";
        }
        public override string validation_choice_cut()
        {
            return "Ok let's erase the orignial file";
        }
        public override string validation_choice_copy()
        {
            return "Ok let's keep the orignial file";
        }
        public override string choice_stain_name()
        {
            return "Please choose the stain name : ";
        }
    }
}
