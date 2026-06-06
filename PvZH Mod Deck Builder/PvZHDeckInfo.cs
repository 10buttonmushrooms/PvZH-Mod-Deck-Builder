namespace PvZH_Mod_Deck_Builder
{
    internal class PvZHDeckInfo
    {
        public string DeckName { get; set; } = "";
        public int[] MainDeckCardIds { get; set; } = [];
        public int[] SuperpowerOverrideCardIds { get; set; } = [];
    }
    internal class EditableDeck
    {
        public static List<CardItem> AllCardItems;
        public List<int> CardIds { get; set; } = [];
        public List<int> UniqueCards()
        {
            return CardIds.Distinct().ToList();
        }
        public int CopiesOfCard(int id)
        {
            int count = CardIds.Count(x => x == id);
            return count;
        }
        public List<(int, int)> CardsAndCopies()
        {
            List<(int, int)> CardsCopies = [];
            foreach (int card in UniqueCards())
            {
                (int, int) CardCopyTuple = (card, CopiesOfCard(card));
                CardsCopies.Add(CardCopyTuple);
            }
            return CardsCopies;
        }
        public string CardsAndCopiesString()
        {
            string str = "";
            foreach ((int, int) CardCopy in CardsAndCopies())
            {
                str += CardCopy.Item1.ToString() + " ×" + CardCopy.Item2.ToString();
                str += "\n";
            }
            return str;
        }
        public static string CardName(int id)
        {
            CardItem card = AllCardItems.Find(x => x.Value == id);
            return card.Name;
        }
        public (string, string) CardAndCopyString(int id)
        {
            return (CardName(id), "×"  + CopiesOfCard(id).ToString());
        }
    }
}