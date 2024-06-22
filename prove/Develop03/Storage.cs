using System.Security.Cryptography.X509Certificates;

public class Storage
{
    public int randomNumb { get; set; }
    public string genScripture()
    {
        string scripture = "";

        if (randomNumb == 1)
        {
            scripture = "D&C 6:36 Look unto me in every thought; doubt not, fear not.";
        }
        else if (randomNumb == 2)
        {
            scripture = "D&C 64:10 I, the Lord, will forgive whom I will forgive, but of you it is required to forgive all men.";
        }
        else if (randomNumb == 3)
        {
            scripture = "2 Nephi 4:30 Rejoice, O my heart, and cry unto the Lord, and say: O Lord, I will praise thee forever; yea, my soul will rejoice in thee, my God, and the rock of my salvation.";
        }
        else if (randomNumb == 4)
        {
            scripture = "Helaman 14:13 And if ye believe on his name ye will repent of all your sins, that thereby ye may have a remission of them through his merits.";
        }
        else if (randomNumb == 5)
        {
            scripture = "John 14:14 If ye shall ask any thing in my name, I will do it. 15. If ye love me, keep my commandments. 16 And I will pray the Father, and he shall give you another Comforter, that he may abide with you for ever;";
        }

        return scripture;
    }
}