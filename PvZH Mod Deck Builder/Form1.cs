using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;

namespace PvZH_Mod_Deck_Builder
{
    public partial class Form1 : Form
    {
        PvZHDeckInfo JsonDeckInfo;
        EditableDeck Deck = new();
        public BindingList<CardItem> AllCardItems = [];
        public BindingList<CardItem> CurrentCardItems = [];
        int SelectedAddedCard = -1;
        int SelectedRemovedCard = -1;
        public Form1()
        {
            InitializeComponent();
            InitializeAllCards();
            InitializeDeck();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bothSidesWarningToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeckLoader.ShowDialog();
        }

        private void DeckLoader_FileOk(object sender, CancelEventArgs e)
        {
            List<string> newStringList = new List<string>();
            using (StreamReader reader = new StreamReader(DeckLoader.FileName))
            {
                string JsonDeck = File.ReadAllText(DeckLoader.FileName);
                try
                {
                    JsonDeckInfo = JsonSerializer.Deserialize<PvZHDeckInfo>(JsonDeck);
                    Deck.CardIds = JsonDeckInfo.MainDeckCardIds.ToList();
                    DeckSaver.FileName = DeckLoader.FileName;
                    DeckUpdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to convert this file to a PvZH Deck.", "ERROR!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(DeckSaver.FileName))
            {
                DeckSaver_FileOk();
            }
            else DeckSaver.ShowDialog();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeckSaver.FileName = "Deck.json";
            DeckSaver.ShowDialog();
        }
        private void DeckSaver_FileOk()
        {
            JsonDeckInfo = new();
            JsonDeckInfo.MainDeckCardIds = Deck.CardIds.ToArray();
            using (StreamWriter writer = new StreamWriter(DeckSaver.FileName))
            {
                string JsonDeck = JsonSerializer.Serialize(JsonDeckInfo);
                writer.Write(JsonDeck);
            }
        }
        private void DeckSaver_FileOk(object sender, CancelEventArgs e)
        {
            JsonDeckInfo = new();
            JsonDeckInfo.MainDeckCardIds = Deck.CardIds.ToArray();
            using (StreamWriter writer = new StreamWriter(DeckSaver.FileName))
            {
                string JsonDeck = JsonSerializer.Serialize(JsonDeckInfo);
                writer.Write(JsonDeck);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CardList.SelectedValue != null) SelectedAddedCard = (int)CardList.SelectedValue;
            else SelectedAddedCard = -1;
        }
        void InitializeAllCards()
        {
            AllCardItems.Add(new CardItem(1, "Guacodile"));
            AllCardItems.Add(new CardItem(2, "Chimney Sweep"));
            AllCardItems.Add(new CardItem(3, "Conga Zombie"));
            AllCardItems.Add(new CardItem(4, "Tennis Champ"));
            AllCardItems.Add(new CardItem(5, "Conehead"));
            AllCardItems.Add(new CardItem(6, "All-Star Zombie"));
            AllCardItems.Add(new CardItem(7, "Smashing Pumpkin"));
            AllCardItems.Add(new CardItem(8, "Navy Bean"));
            AllCardItems.Add(new CardItem(9, "Pismashio"));
            AllCardItems.Add(new CardItem(10, "Peashooter"));
            AllCardItems.Add(new CardItem(11, "Squash"));
            AllCardItems.Add(new CardItem(12, "Bungee Plumber"));
            AllCardItems.Add(new CardItem(15, "Monster Mash"));
            AllCardItems.Add(new CardItem(18, "Sour Grapes"));
            AllCardItems.Add(new CardItem(19, "Cabbage-Pult"));
            AllCardItems.Add(new CardItem(20, "Grow-Shroom"));
            AllCardItems.Add(new CardItem(21, "Berry Angry"));
            AllCardItems.Add(new CardItem(22, "Medic"));
            AllCardItems.Add(new CardItem(23, "Fishy Imp"));
            AllCardItems.Add(new CardItem(24, "The Chickening"));
            AllCardItems.Add(new CardItem(25, "Precision Blast"));
            AllCardItems.Add(new CardItem(26, "Slammin' Smackdown"));
            AllCardItems.Add(new CardItem(27, "Carried Away"));
            AllCardItems.Add(new CardItem(28, "Imp"));
            AllCardItems.Add(new CardItem(29, "Sea-Shroom"));
            AllCardItems.Add(new CardItem(30, "Smoosh-Shroom"));
            AllCardItems.Add(new CardItem(31, "Bonk Choy"));
            AllCardItems.Add(new CardItem(32, "Vanilla"));
            AllCardItems.Add(new CardItem(33, "Bluesberry"));
            AllCardItems.Add(new CardItem(35, "Zapricot"));
            AllCardItems.Add(new CardItem(36, "Berry Blast"));
            AllCardItems.Add(new CardItem(37, "Storm Front"));
            AllCardItems.Add(new CardItem(38, "Meteor Strike"));
            AllCardItems.Add(new CardItem(39, "Fire Peashooter"));
            AllCardItems.Add(new CardItem(40, "Flourish"));
            AllCardItems.Add(new CardItem(41, "Fertilize"));
            AllCardItems.Add(new CardItem(42, "Embiggen"));
            AllCardItems.Add(new CardItem(43, "Skyshooter"));
            AllCardItems.Add(new CardItem(44, "Holo-Flora"));
            AllCardItems.Add(new CardItem(45, "Cattail"));
            AllCardItems.Add(new CardItem(46, "2nd-Best Taco of All Time"));
            AllCardItems.Add(new CardItem(47, "Weed Whack"));
            AllCardItems.Add(new CardItem(48, "Scorched Earth"));
            AllCardItems.Add(new CardItem(49, "Cell Phone Zombie"));
            AllCardItems.Add(new CardItem(50, "Zombie"));
            AllCardItems.Add(new CardItem(51, "Fun-Dead Raiser"));
            AllCardItems.Add(new CardItem(52, "Drum Major"));
            AllCardItems.Add(new CardItem(53, "Kite Flyer"));
            AllCardItems.Add(new CardItem(54, "Landscaper"));
            AllCardItems.Add(new CardItem(55, "Rock Wall"));
            AllCardItems.Add(new CardItem(56, "Heroic Health"));
            AllCardItems.Add(new CardItem(57, "Terrify"));
            AllCardItems.Add(new CardItem(58, "Snorkel Zombie"));
            AllCardItems.Add(new CardItem(59, "Vitamin Z"));
            AllCardItems.Add(new CardItem(60, "Locust Swarm"));
            AllCardItems.Add(new CardItem(61, "Cat Lady"));
            AllCardItems.Add(new CardItem(62, "Dolphin Rider"));
            AllCardItems.Add(new CardItem(63, "Galvanize"));
            AllCardItems.Add(new CardItem(64, "Nibble"));
            AllCardItems.Add(new CardItem(65, "Deep Sea Gargantuar"));
            AllCardItems.Add(new CardItem(66, "Zombot 1000"));
            AllCardItems.Add(new CardItem(67, "Cuckoo Zombie"));
            AllCardItems.Add(new CardItem(68, "Electrobolt"));
            AllCardItems.Add(new CardItem(69, "Brute Strength"));
            AllCardItems.Add(new CardItem(70, "Cakesplosion"));
            AllCardItems.Add(new CardItem(71, "Walrus Rider"));
            AllCardItems.Add(new CardItem(72, "Uncrackable"));
            AllCardItems.Add(new CardItem(73, "Blazing Bark"));
            AllCardItems.Add(new CardItem(74, "Shrink Ray"));
            AllCardItems.Add(new CardItem(75, "Sunburn"));
            AllCardItems.Add(new CardItem(76, "Admiral Navy Bean"));
            AllCardItems.Add(new CardItem(77, "Wall-Nut"));
            AllCardItems.Add(new CardItem(78, "Cactus"));
            AllCardItems.Add(new CardItem(79, "Steel Magnolia"));
            AllCardItems.Add(new CardItem(80, "Jugger-Nut"));
            AllCardItems.Add(new CardItem(81, "Smackadamia"));
            AllCardItems.Add(new CardItem(82, "Poppin' Poppies"));
            AllCardItems.Add(new CardItem(83, "Hibernating Beary"));
            AllCardItems.Add(new CardItem(84, "Potato Mine"));
            AllCardItems.Add(new CardItem(86, "Bubble Up"));
            AllCardItems.Add(new CardItem(87, "Grave Buster"));
            AllCardItems.Add(new CardItem(88, "Water Chestnut"));
            AllCardItems.Add(new CardItem(89, "Sting Bean"));
            AllCardItems.Add(new CardItem(90, "Pea-Nut"));
            AllCardItems.Add(new CardItem(91, "Prickly Pear"));
            AllCardItems.Add(new CardItem(92, "Spineapple"));
            AllCardItems.Add(new CardItem(94, "Soul Patch"));
            AllCardItems.Add(new CardItem(95, "Wall-Nut Bowling"));
            AllCardItems.Add(new CardItem(96, "Nut Signal"));
            AllCardItems.Add(new CardItem(97, "Shroom for Two"));
            AllCardItems.Add(new CardItem(98, "Mushroom Ringleader"));
            AllCardItems.Add(new CardItem(99, "Poison Ivy"));
            AllCardItems.Add(new CardItem(100, "Buff-Shroom"));
            AllCardItems.Add(new CardItem(101, "Petal-Morphosis"));
            AllCardItems.Add(new CardItem(102, "Cherry Bomb"));
            AllCardItems.Add(new CardItem(103, "Wild Berry"));
            AllCardItems.Add(new CardItem(104, "Pair of Pears"));
            AllCardItems.Add(new CardItem(105, "Poison Mushroom"));
            AllCardItems.Add(new CardItem(106, "Sizzle"));
            AllCardItems.Add(new CardItem(107, "Seedling"));
            AllCardItems.Add(new CardItem(108, "Grapes of Wrath"));
            AllCardItems.Add(new CardItem(109, "Sergeant Strongberry"));
            AllCardItems.Add(new CardItem(110, "Pineclone"));
            AllCardItems.Add(new CardItem(111, "Cornucopia"));
            AllCardItems.Add(new CardItem(113, "Repeater"));
            AllCardItems.Add(new CardItem(114, "Torchwood"));
            AllCardItems.Add(new CardItem(115, "Super-Phat Beets"));
            AllCardItems.Add(new CardItem(116, "Pea Pod"));
            AllCardItems.Add(new CardItem(117, "Party Thyme"));
            AllCardItems.Add(new CardItem(118, "Plant Food"));
            AllCardItems.Add(new CardItem(119, "Sweet Potato"));
            AllCardItems.Add(new CardItem(120, "Re-Peat Moss"));
            AllCardItems.Add(new CardItem(122, "Black-Eyed Pea"));
            AllCardItems.Add(new CardItem(123, "Potted Powerhouse"));
            AllCardItems.Add(new CardItem(124, "Morning Glory"));
            AllCardItems.Add(new CardItem(125, "Doubled Mint"));
            AllCardItems.Add(new CardItem(126, "Bananasaurus Rex"));
            AllCardItems.Add(new CardItem(127, "Jumping Bean"));
            AllCardItems.Add(new CardItem(128, "Chilly Pepper"));
            AllCardItems.Add(new CardItem(129, "Spring Bean"));
            AllCardItems.Add(new CardItem(130, "Rescue Radish"));
            AllCardItems.Add(new CardItem(131, "Snowdrop"));
            AllCardItems.Add(new CardItem(132, "Carrotillery"));
            AllCardItems.Add(new CardItem(133, "Threepeater"));
            AllCardItems.Add(new CardItem(134, "Winter Squash"));
            AllCardItems.Add(new CardItem(135, "Big Chill"));
            AllCardItems.Add(new CardItem(136, "Whirlwind"));
            AllCardItems.Add(new CardItem(137, "Snow Pea"));
            AllCardItems.Add(new CardItem(138, "Shellery"));
            AllCardItems.Add(new CardItem(139, "Fume-Shroom"));
            AllCardItems.Add(new CardItem(140, "Iceberg Lettuce"));
            AllCardItems.Add(new CardItem(141, "Bean Counter"));
            AllCardItems.Add(new CardItem(142, "Brainana"));
            AllCardItems.Add(new CardItem(143, "Winter Melon"));
            AllCardItems.Add(new CardItem(145, "Snapdragon"));
            AllCardItems.Add(new CardItem(146, "Transmogrify"));
            AllCardItems.Add(new CardItem(147, "Sunflower"));
            AllCardItems.Add(new CardItem(148, "Sage Sage"));
            AllCardItems.Add(new CardItem(149, "Mixed Nuts"));
            AllCardItems.Add(new CardItem(150, "Bloomerang"));
            AllCardItems.Add(new CardItem(151, "Power Flower"));
            AllCardItems.Add(new CardItem(152, "Venus Flytrap"));
            AllCardItems.Add(new CardItem(153, "Pepper M.D."));
            AllCardItems.Add(new CardItem(154, "Metal Petal Sunflower"));
            AllCardItems.Add(new CardItem(155, "Geyser"));
            AllCardItems.Add(new CardItem(156, "Muscle Sprout"));
            AllCardItems.Add(new CardItem(157, "Twin Sunflower"));
            AllCardItems.Add(new CardItem(158, "Laser Bean"));
            AllCardItems.Add(new CardItem(159, "Lawnmower"));
            AllCardItems.Add(new CardItem(160, "Chomper"));
            AllCardItems.Add(new CardItem(161, "Magnifying Grass"));
            AllCardItems.Add(new CardItem(163, "Briar Rose"));
            AllCardItems.Add(new CardItem(164, "Dandy Lion King"));
            AllCardItems.Add(new CardItem(165, "Three-Headed Chomper"));
            AllCardItems.Add(new CardItem(166, "Space Cadet"));
            AllCardItems.Add(new CardItem(167, "Electrician"));
            AllCardItems.Add(new CardItem(168, "Paparazzi Zombie"));
            AllCardItems.Add(new CardItem(169, "Pool Shark"));
            AllCardItems.Add(new CardItem(170, "Gadget Scientist"));
            AllCardItems.Add(new CardItem(171, "Rocket Science"));
            AllCardItems.Add(new CardItem(172, "Cut Down to Size"));
            AllCardItems.Add(new CardItem(174, "Zombot Drone Engineer"));
            AllCardItems.Add(new CardItem(175, "Brain Vendor"));
            AllCardItems.Add(new CardItem(176, "Copter Commando"));
            AllCardItems.Add(new CardItem(177, "Lurch for Lunch"));
            AllCardItems.Add(new CardItem(178, "Wizard Gargantuar"));
            AllCardItems.Add(new CardItem(180, "Mad Chemist"));
            AllCardItems.Add(new CardItem(181, "Trickster"));
            AllCardItems.Add(new CardItem(182, "Shieldcrusher Viking"));
            AllCardItems.Add(new CardItem(185, "Evaporate"));
            AllCardItems.Add(new CardItem(186, "Arm Wrestler"));
            AllCardItems.Add(new CardItem(187, "Sumo Wrestler"));
            AllCardItems.Add(new CardItem(188, "Power Pummel"));
            AllCardItems.Add(new CardItem(189, "Rolling Stone"));
            AllCardItems.Add(new CardItem(190, "Zombie Coach"));
            AllCardItems.Add(new CardItem(191, "Flag Zombie"));
            AllCardItems.Add(new CardItem(193, "Buckethead"));
            AllCardItems.Add(new CardItem(194, "Trash Can Zombie"));
            AllCardItems.Add(new CardItem(195, "Knight of the Living Dead"));
            AllCardItems.Add(new CardItem(196, "Ra Zombie"));
            AllCardItems.Add(new CardItem(197, "Weed Spray"));
            AllCardItems.Add(new CardItem(198, "Rodeo Gargantuar"));
            AllCardItems.Add(new CardItem(199, "Zombie King"));
            AllCardItems.Add(new CardItem(200, "Team Mascot"));
            AllCardItems.Add(new CardItem(201, "Undying Pharaoh"));
            AllCardItems.Add(new CardItem(202, "Wannabe Hero"));
            AllCardItems.Add(new CardItem(203, "Zombot's Wrath"));
            AllCardItems.Add(new CardItem(204, "Dog Walker"));
            AllCardItems.Add(new CardItem(205, "Pied Piper"));
            AllCardItems.Add(new CardItem(206, "Haunting Zombie"));
            AllCardItems.Add(new CardItem(207, "Smashing Gargantuar"));
            AllCardItems.Add(new CardItem(208, "Zookeeper"));
            AllCardItems.Add(new CardItem(209, "Coffee Zombie"));
            AllCardItems.Add(new CardItem(210, "Acid Rain"));
            AllCardItems.Add(new CardItem(213, "B-flat"));
            AllCardItems.Add(new CardItem(214, "Zombie Yeti"));
            AllCardItems.Add(new CardItem(215, "Kangaroo Rider"));
            AllCardItems.Add(new CardItem(216, "Nurse Gargantuar"));
            AllCardItems.Add(new CardItem(217, "Maniacal Laugh"));
            AllCardItems.Add(new CardItem(218, "Octo Zombie"));
            AllCardItems.Add(new CardItem(219, "Possessed"));
            AllCardItems.Add(new CardItem(220, "Exploding Imp"));
            AllCardItems.Add(new CardItem(221, "Newspaper Zombie"));
            AllCardItems.Add(new CardItem(222, "Orchestra Conductor"));
            AllCardItems.Add(new CardItem(223, "Flamenco Zombie"));
            AllCardItems.Add(new CardItem(224, "Disco Zombie"));
            AllCardItems.Add(new CardItem(225, "Imp-Throwing Gargantuar"));
            AllCardItems.Add(new CardItem(226, "Unlife of the Party"));
            AllCardItems.Add(new CardItem(227, "Jester"));
            AllCardItems.Add(new CardItem(228, "Foot Soldier Zombie"));
            AllCardItems.Add(new CardItem(230, "Fireworks Zombie"));
            AllCardItems.Add(new CardItem(231, "Valkyrie"));
            AllCardItems.Add(new CardItem(234, "Disco-Tron 3000"));
            AllCardItems.Add(new CardItem(235, "Gargantuars' Feast"));
            AllCardItems.Add(new CardItem(236, "Dance Off"));
            AllCardItems.Add(new CardItem(237, "Zombie Chicken"));
            AllCardItems.Add(new CardItem(238, "Stealthy Imp"));
            AllCardItems.Add(new CardItem(239, "Smelly Zombie"));
            AllCardItems.Add(new CardItem(240, "Backyard Bounce"));
            AllCardItems.Add(new CardItem(241, "Imp Commander"));
            AllCardItems.Add(new CardItem(242, "Swashbuckler Zombie"));
            AllCardItems.Add(new CardItem(243, "Surprise Gargantuar"));
            AllCardItems.Add(new CardItem(245, "Super Stench"));
            AllCardItems.Add(new CardItem(246, "Dolphinado"));
            AllCardItems.Add(new CardItem(247, "Toxic Waste Imp"));
            AllCardItems.Add(new CardItem(248, "Pogo Bouncer"));
            AllCardItems.Add(new CardItem(249, "Line Dancing Zombie"));
            AllCardItems.Add(new CardItem(250, "Mini-Ninja"));
            AllCardItems.Add(new CardItem(251, "Barrel Roller Zombie"));
            AllCardItems.Add(new CardItem(252, "Mixed-Up Gravedigger"));
            AllCardItems.Add(new CardItem(253, "Tomb Raiser Zombie"));
            AllCardItems.Add(new CardItem(255, "Vimpire"));
            AllCardItems.Add(new CardItem(256, "Zombot Sharktronic Sub"));
            AllCardItems.Add(new CardItem(257, "Zombot Plank Walker"));
            AllCardItems.Add(new CardItem(258, "In-Crypted"));
            AllCardItems.Add(new CardItem(259, "Hothead"));
            AllCardItems.Add(new CardItem(261, "Mush-Boom"));
            AllCardItems.Add(new CardItem(262, "Goatify"));
            AllCardItems.Add(new CardItem(263, "Devour"));
            AllCardItems.Add(new CardItem(264, "Eureka"));
            AllCardItems.Add(new CardItem(265, "Missile Madness"));
            AllCardItems.Add(new CardItem(267, "Stayin' Alive"));
            AllCardItems.Add(new CardItem(268, "Octo-Pult"));
            AllCardItems.Add(new CardItem(269, "Frozen Tundra"));
            AllCardItems.Add(new CardItem(270, "Impfinity Clone"));
            AllCardItems.Add(new CardItem(271, "Inspire"));
            AllCardItems.Add(new CardItem(272, "Motivate"));
            AllCardItems.Add(new CardItem(273, "Flick-a-Plant"));
            AllCardItems.Add(new CardItem(274, "Flick-a-Zombie"));
            AllCardItems.Add(new CardItem(275, "Get Well"));
            AllCardItems.Add(new CardItem(276, "Rejuvenate"));
            AllCardItems.Add(new CardItem(277, "Plumber"));
            AllCardItems.Add(new CardItem(278, "0 PLANT CHEATS 0"));
            AllCardItems.Add(new CardItem(279, "0 ZOMBIE CHEATS 0"));
            AllCardItems.Add(new CardItem(280, "0 Plant Board Clear Cheat 0"));
            AllCardItems.Add(new CardItem(281, "Lil' Buddy"));
            AllCardItems.Add(new CardItem(282, "Pear Pal"));
            AllCardItems.Add(new CardItem(283, "Time to Shine"));
            AllCardItems.Add(new CardItem(284, "Espresso Fiesta"));
            AllCardItems.Add(new CardItem(285, "Beam Me Up"));
            AllCardItems.Add(new CardItem(286, "Hail-a-Copter"));
            AllCardItems.Add(new CardItem(287, "Backup Dancer"));
            AllCardItems.Add(new CardItem(289, "Tater Toss"));
            AllCardItems.Add(new CardItem(290, "Octo-Pet"));
            AllCardItems.Add(new CardItem(291, "Triple Threat"));
            AllCardItems.Add(new CardItem(293, "Poison Oak"));
            AllCardItems.Add(new CardItem(294, "Kernel Corn"));
            AllCardItems.Add(new CardItem(295, "More Spore"));
            AllCardItems.Add(new CardItem(296, "The Podfather"));
            AllCardItems.Add(new CardItem(297, "Whipvine"));
            AllCardItems.Add(new CardItem(298, "Gardening Gloves"));
            AllCardItems.Add(new CardItem(299, "Lightning Reed"));
            AllCardItems.Add(new CardItem(300, "Water Balloons"));
            AllCardItems.Add(new CardItem(301, "Summoning"));
            AllCardItems.Add(new CardItem(304, "Portal Technician"));
            AllCardItems.Add(new CardItem(305, "Root Wall"));
            AllCardItems.Add(new CardItem(306, "Loudmouth"));
            AllCardItems.Add(new CardItem(307, "Squirrel Herder"));
            AllCardItems.Add(new CardItem(308, "Aerobics Instructor"));
            AllCardItems.Add(new CardItem(309, "Abracadaver"));
            AllCardItems.Add(new CardItem(310, "Firefighter"));
            AllCardItems.Add(new CardItem(312, "Puff-Shroom"));
            AllCardItems.Add(new CardItem(313, "Mountain Climber"));
            AllCardItems.Add(new CardItem(314, "The Great Zucchini"));
            AllCardItems.Add(new CardItem(315, "Doom-Shroom"));
            AllCardItems.Add(new CardItem(316, "Mirror-Nut"));
            AllCardItems.Add(new CardItem(317, "Gentleman Zombie"));
            AllCardItems.Add(new CardItem(319, "Telepathy"));
            AllCardItems.Add(new CardItem(321, "Smoke Bomb"));
            AllCardItems.Add(new CardItem(322, "Camel Crossing"));
            AllCardItems.Add(new CardItem(323, "Headstone Carver"));
            AllCardItems.Add(new CardItem(324, "Tough Beets"));
            AllCardItems.Add(new CardItem(326, "Weenie Beanie"));
            AllCardItems.Add(new CardItem(327, "Barrel of Deadbeards"));
            AllCardItems.Add(new CardItem(328, "Captain Flameface"));
            AllCardItems.Add(new CardItem(329, "Witch's Familiar"));
            AllCardItems.Add(new CardItem(330, "Yeti Lunchbox"));
            AllCardItems.Add(new CardItem(331, "Zom-Bats"));
            AllCardItems.Add(new CardItem(332, "Goat"));
            AllCardItems.Add(new CardItem(333, "Sow Magic Beans"));
            AllCardItems.Add(new CardItem(335, "0 Cheating Zombie 0"));
            AllCardItems.Add(new CardItem(338, "0 Zombie Board Clear Cheat 0"));
            AllCardItems.Add(new CardItem(339, "Punish-Shroom"));
            AllCardItems.Add(new CardItem(340, "Zombot Stomp"));
            AllCardItems.Add(new CardItem(341, "Peel Shield"));
            AllCardItems.Add(new CardItem(344, "Swabbie"));
            AllCardItems.Add(new CardItem(346, "Whack-a-Zombie"));
            AllCardItems.Add(new CardItem(398, "Mushroom Grotto"));
            AllCardItems.Add(new CardItem(399, "Coffee Grounds"));
            AllCardItems.Add(new CardItem(401, "Laser Base Alpha"));
            AllCardItems.Add(new CardItem(408, "Trick-or-Treater"));
            AllCardItems.Add(new CardItem(415, "Spikeweed Sector"));
            AllCardItems.Add(new CardItem(417, "Photosynthesizer"));
            AllCardItems.Add(new CardItem(418, "Starch-Lord"));
            AllCardItems.Add(new CardItem(420, "Force Field"));
            AllCardItems.Add(new CardItem(421, "Body-Gourd"));
            AllCardItems.Add(new CardItem(423, "Health-Nut"));
            AllCardItems.Add(new CardItem(427, "Galacta-Cactus"));
            AllCardItems.Add(new CardItem(431, "Hot Lava"));
            AllCardItems.Add(new CardItem(433, "Banana Bomb"));
            AllCardItems.Add(new CardItem(434, "Astro-Shroom"));
            AllCardItems.Add(new CardItem(438, "High-Voltage Currant"));
            AllCardItems.Add(new CardItem(439, "Blooming Heart"));
            AllCardItems.Add(new CardItem(442, "Vegetation Mutation"));
            AllCardItems.Add(new CardItem(443, "The Red Plant-It"));
            AllCardItems.Add(new CardItem(456, "Planet of the Grapes"));
            AllCardItems.Add(new CardItem(459, "Sap-Fling"));
            AllCardItems.Add(new CardItem(460, "Sappy Place"));
            AllCardItems.Add(new CardItem(461, "Cool Bean"));
            AllCardItems.Add(new CardItem(462, "Bog of Enlightenment"));
            AllCardItems.Add(new CardItem(464, "Dark Matter Dragonfruit"));
            AllCardItems.Add(new CardItem(465, "Melon-Pult"));
            AllCardItems.Add(new CardItem(467, "Apple-Saucer"));
            AllCardItems.Add(new CardItem(468, "Wing-Nut"));
            AllCardItems.Add(new CardItem(469, "Venus Flytraplanet"));
            AllCardItems.Add(new CardItem(473, "Half-Banana"));
            AllCardItems.Add(new CardItem(476, "Solar Winds"));
            AllCardItems.Add(new CardItem(477, "Astro Vera"));
            AllCardItems.Add(new CardItem(479, "Sun-Shroom"));
            AllCardItems.Add(new CardItem(481, "Haunted Pumpking"));
            AllCardItems.Add(new CardItem(484, "Area 22"));
            AllCardItems.Add(new CardItem(485, "Cosmic Yeti"));
            AllCardItems.Add(new CardItem(486, "Escape through Time"));
            AllCardItems.Add(new CardItem(489, "Total Eclipse"));
            AllCardItems.Add(new CardItem(490, "Interstellar Bounty Hunter"));
            AllCardItems.Add(new CardItem(496, "Cryo-Brain"));
            AllCardItems.Add(new CardItem(497, "Moonwalker"));
            AllCardItems.Add(new CardItem(498, "Medulla Nebula"));
            AllCardItems.Add(new CardItem(503, "Transformation Station"));
            AllCardItems.Add(new CardItem(505, "Interdimensional Zombie"));
            AllCardItems.Add(new CardItem(507, "Thinking Cap"));
            AllCardItems.Add(new CardItem(510, "Disco-Naut"));
            AllCardItems.Add(new CardItem(512, "Meteor Z"));
            AllCardItems.Add(new CardItem(515, "Quasar Wizard"));
            AllCardItems.Add(new CardItem(517, "Moon Base Z"));
            AllCardItems.Add(new CardItem(521, "Gargantuar-Throwing Imp"));
            AllCardItems.Add(new CardItem(525, "Celestial Custodian"));
            AllCardItems.Add(new CardItem(528, "Biodome Botanist"));
            AllCardItems.Add(new CardItem(529, "Planetary Gladiator"));
            AllCardItems.Add(new CardItem(531, "Black Hole"));
            AllCardItems.Add(new CardItem(533, "Zombot Battlecruiser 5000"));
            AllCardItems.Add(new CardItem(535, "Genetic Experiment"));
            AllCardItems.Add(new CardItem(542, "Dr. Spacetime"));
            AllCardItems.Add(new CardItem(545, "Cryo-Yeti"));
            AllCardItems.Add(new CardItem(551, "Plucky Clover"));
            AllCardItems.Add(new CardItem(558, "Sunnier-Shroom"));
            AllCardItems.Add(new CardItem(573, "Ensign Uproot"));
            AllCardItems.Add(new CardItem(574, "Lieutenant Carrotron"));
            AllCardItems.Add(new CardItem(576, "Terror-Former 10,000"));
            AllCardItems.Add(new CardItem(579, "Ice Moon"));
            AllCardItems.Add(new CardItem(595, "Blockbuster"));
            AllCardItems.Add(new CardItem(599, "Imitater"));
            AllCardItems.Add(new CardItem(613, "Primordial Cheese Shover"));
            AllCardItems.Add(new CardItem(616, "Extinction Event"));
            AllCardItems.Add(new CardItem(617, "Mondo Bronto"));
            AllCardItems.Add(new CardItem(618, "Zom-Blob"));
            AllCardItems.Add(new CardItem(622, "Gizzard Lizard"));
            AllCardItems.Add(new CardItem(623, "Quickdraw Con Man"));
            AllCardItems.Add(new CardItem(625, "Primeval Yeti"));
            AllCardItems.Add(new CardItem(627, "Stompadon"));
            AllCardItems.Add(new CardItem(630, "Cursed Gargolith"));
            AllCardItems.Add(new CardItem(632, "Cro-Magnolia"));
            AllCardItems.Add(new CardItem(635, "Tankylosaurus"));
            AllCardItems.Add(new CardItem(637, "Transfiguration"));
            AllCardItems.Add(new CardItem(647, "Marine Bean"));
            AllCardItems.Add(new CardItem(648, "Loco Coco"));
            AllCardItems.Add(new CardItem(651, "Veloci-Radish Hunters/Packmates"));
            AllCardItems.Add(new CardItem(659, "Lily Pad"));
            AllCardItems.Add(new CardItem(661, "Shrinking Violet"));
            AllCardItems.Add(new CardItem(663, "Sun Strike"));
            AllCardItems.Add(new CardItem(671, "Pirate's Booty"));
            AllCardItems.Add(new CardItem(673, "Duckstache"));
            AllCardItems.Add(new CardItem(677, "Knockout"));
            AllCardItems.Add(new CardItem(678, "Headhunter/Bobblehead"));
            AllCardItems.Add(new CardItem(680, "Lost Colosseum"));
            AllCardItems.Add(new CardItem(682, "Chum Champion"));
            AllCardItems.Add(new CardItem(685, "Monkey Smuggler"));
            AllCardItems.Add(new CardItem(686, "Unthawed Viking"));
            AllCardItems.Add(new CardItem(687, "Raiding Raptor"));
            AllCardItems.Add(new CardItem(690, "Captain Deadbeard"));
            AllCardItems.Add(new CardItem(691, "Veloci-Radish Hatchling"));
            AllCardItems.Add(new CardItem(334, "Teleport"));
            AllCardItems.Add(new CardItem(336, "Blank Plant"));
            AllCardItems.Add(new CardItem(337, "Blank Zombie"));
            AllCardItems.Add(new CardItem(342, "Haunting Ghost"));
            AllCardItems.Add(new CardItem(345, "Magic Beanstalk"));
            AllCardItems.Add(new CardItem(347, "Small-Nut"));
            AllCardItems.Add(new CardItem(348, "Button Mushroom"));
            AllCardItems.Add(new CardItem(349, "Bellflower"));
            AllCardItems.Add(new CardItem(350, "Cardboard Robot Zombie"));
            AllCardItems.Add(new CardItem(351, "Baseball Zombie"));
            AllCardItems.Add(new CardItem(352, "Skunk Punk"));
            AllCardItems.Add(new CardItem(353, "Hot Dog Imp"));
            AllCardItems.Add(new CardItem(402, "Regifting Zombie"));
            AllCardItems.Add(new CardItem(403, "Jack O' Lantern"));
            AllCardItems.Add(new CardItem(404, "Leftovers"));
            AllCardItems.Add(new CardItem(405, "Turkey Rider"));
            AllCardItems.Add(new CardItem(406, "Healthy Treat"));
            AllCardItems.Add(new CardItem(407, "Sugary Treat"));
            AllCardItems.Add(new CardItem(409, "Jolly Holly"));
            AllCardItems.Add(new CardItem(410, "Mayflower"));
            AllCardItems.Add(new CardItem(411, "Red Stinger"));
            AllCardItems.Add(new CardItem(412, "Pot of Gold"));
            AllCardItems.Add(new CardItem(413, "Corn Dog"));
            AllCardItems.Add(new CardItem(414, "Plantern"));
            AllCardItems.Add(new CardItem(416, "Cosmic Nut"));
            AllCardItems.Add(new CardItem(419, "Gravitree"));
            AllCardItems.Add(new CardItem(422, "Pecanolith"));
            AllCardItems.Add(new CardItem(424, "Pear Cub"));
            AllCardItems.Add(new CardItem(425, "Grizzly Pear"));
            AllCardItems.Add(new CardItem(426, "Garlic"));
            AllCardItems.Add(new CardItem(428, "Invasive Species"));
            AllCardItems.Add(new CardItem(429, "Cosmic Mushroom"));
            AllCardItems.Add(new CardItem(430, "Lava Guava"));
            AllCardItems.Add(new CardItem(432, "Banana Launcher"));
            AllCardItems.Add(new CardItem(435, "Sonic Bloom"));
            AllCardItems.Add(new CardItem(436, "Molekale"));
            AllCardItems.Add(new CardItem(437, "Electric Blueberry"));
            AllCardItems.Add(new CardItem(440, "Reincarnation"));
            AllCardItems.Add(new CardItem(441, "Sweet Pea"));
            AllCardItems.Add(new CardItem(444, "Cosmic Pea"));
            AllCardItems.Add(new CardItem(445, "Banana Peel"));
            AllCardItems.Add(new CardItem(446, "Cosmoss"));
            AllCardItems.Add(new CardItem(447, "Moonbean"));
            AllCardItems.Add(new CardItem(448, "Onion Rings"));
            AllCardItems.Add(new CardItem(449, "Captain Cucumber"));
            AllCardItems.Add(new CardItem(450, "Clique Peas"));
            AllCardItems.Add(new CardItem(451, "Lily of the Valley"));
            AllCardItems.Add(new CardItem(452, "Snake Grass"));
            AllCardItems.Add(new CardItem(453, "Pod Fighter"));
            AllCardItems.Add(new CardItem(454, "Laser Cattail"));
            AllCardItems.Add(new CardItem(455, "Leaf Blower"));
            AllCardItems.Add(new CardItem(457, "Cosmic Bean"));
            AllCardItems.Add(new CardItem(458, "Mars Flytrap"));
            AllCardItems.Add(new CardItem(463, "Shooting Starfruit"));
            AllCardItems.Add(new CardItem(466, "Spyris"));
            AllCardItems.Add(new CardItem(470, "Cosmic Flower"));
            AllCardItems.Add(new CardItem(471, "Heartichoke"));
            AllCardItems.Add(new CardItem(472, "Banana Split"));
            AllCardItems.Add(new CardItem(474, "Astrocado"));
            AllCardItems.Add(new CardItem(475, "Astrocado Pit"));
            AllCardItems.Add(new CardItem(478, "Tactical Cuke"));
            AllCardItems.Add(new CardItem(480, "Toadstool"));
            AllCardItems.Add(new CardItem(482, "Kitchen Sink Zombie"));
            AllCardItems.Add(new CardItem(483, "Alien Ooze"));
            AllCardItems.Add(new CardItem(487, "Surfer Zombie"));
            AllCardItems.Add(new CardItem(488, "Cyborg Zombie"));
            AllCardItems.Add(new CardItem(491, "Supernova Gargantaur"));
            AllCardItems.Add(new CardItem(492, "Secret Agent"));
            AllCardItems.Add(new CardItem(493, "Synchronized Swimmer"));
            AllCardItems.Add(new CardItem(494, "Energy Drink Zombie"));
            AllCardItems.Add(new CardItem(495, "Overstuffed Zombie"));
            AllCardItems.Add(new CardItem(499, "Triplication"));
            AllCardItems.Add(new CardItem(500, "Cosmic Scientist"));
            AllCardItems.Add(new CardItem(501, "Wormhole Gatekeeper"));
            AllCardItems.Add(new CardItem(502, "Neutron Imp"));
            AllCardItems.Add(new CardItem(504, "Teleportation Zombie"));
            AllCardItems.Add(new CardItem(506, "Zombology Teacher"));
            AllCardItems.Add(new CardItem(508, "Leprechaun Imp"));
            AllCardItems.Add(new CardItem(511, "Space Ninja"));
            AllCardItems.Add(new CardItem(513, "Cosmic Dancer"));
            AllCardItems.Add(new CardItem(514, "Final Mission"));
            AllCardItems.Add(new CardItem(516, "Loose Cannon"));
            AllCardItems.Add(new CardItem(518, "Binary Stars"));
            AllCardItems.Add(new CardItem(519, "Gas Giant"));
            AllCardItems.Add(new CardItem(520, "Stupid Cupid"));
            AllCardItems.Add(new CardItem(524, "Screen Door Zombie"));
            AllCardItems.Add(new CardItem(526, "Cone Zone"));
            AllCardItems.Add(new CardItem(527, "Cosmic Sports Star"));
            AllCardItems.Add(new CardItem(530, "Going Viral"));
            AllCardItems.Add(new CardItem(532, "Intergalactic Warlord"));
            AllCardItems.Add(new CardItem(534, "Defensive End"));
            AllCardItems.Add(new CardItem(536, "Gargologist"));
            AllCardItems.Add(new CardItem(537, "Ducky Tube Zombie"));
            AllCardItems.Add(new CardItem(538, "Ice Pirate"));
            AllCardItems.Add(new CardItem(539, "Graveyard"));
            AllCardItems.Add(new CardItem(540, "Cosmic Imp"));
            AllCardItems.Add(new CardItem(541, "Frosty Mustache"));
            AllCardItems.Add(new CardItem(543, "Space Pirate"));
            AllCardItems.Add(new CardItem(544, "Space Cowboy"));
            AllCardItems.Add(new CardItem(546, "Cheese Cutter"));
            AllCardItems.Add(new CardItem(547, "Zombie High Diver"));
            AllCardItems.Add(new CardItem(548, "Imposter"));
            AllCardItems.Add(new CardItem(549, "Trapper Zombie"));
            AllCardItems.Add(new CardItem(550, "Fire Rooster"));
            AllCardItems.Add(new CardItem(552, "Hot Date"));
            AllCardItems.Add(new CardItem(553, "Bonus Track Buckethead"));
            AllCardItems.Add(new CardItem(554, "Shamrocket"));
            AllCardItems.Add(new CardItem(555, "Sportacus"));
            AllCardItems.Add(new CardItem(556, "Hippity Hop Gargantuar"));
            AllCardItems.Add(new CardItem(557, "Mystery Egg"));
            AllCardItems.Add(new CardItem(560, "Vengeful Cyborg"));
            AllCardItems.Add(new CardItem(566, "Pair Pearadise"));
            AllCardItems.Add(new CardItem(568, "King of the Grill"));
            AllCardItems.Add(new CardItem(569, "Trapper Territory"));
            AllCardItems.Add(new CardItem(572, "Genetic Amplification"));
            AllCardItems.Add(new CardItem(575, "Lightspeed Seed"));
            AllCardItems.Add(new CardItem(577, "Iron Boarder"));
            AllCardItems.Add(new CardItem(578, "Teleportation Station"));
            AllCardItems.Add(new CardItem(585, "Hover-Goat 3000"));
            AllCardItems.Add(new CardItem(586, "Bad Moon Rising"));
            AllCardItems.Add(new CardItem(587, "Imp-Throwing Imp"));
            AllCardItems.Add(new CardItem(588, "Forget-Me-Nuts"));
            AllCardItems.Add(new CardItem(589, "Atomic Bombegranate"));
            AllCardItems.Add(new CardItem(591, "Go-Nuts"));
            AllCardItems.Add(new CardItem(594, "Primal Potato Mine"));
            AllCardItems.Add(new CardItem(596, "Grape Responsibility"));
            AllCardItems.Add(new CardItem(597, "Three-Nut"));
            AllCardItems.Add(new CardItem(598, "Tricarrotops"));
            AllCardItems.Add(new CardItem(600, "Gloom-Shroom"));
            AllCardItems.Add(new CardItem(601, "Umbrella Leaf"));
            AllCardItems.Add(new CardItem(602, "Bamboozle"));
            AllCardItems.Add(new CardItem(603, "Split Pea"));
            AllCardItems.Add(new CardItem(604, "Grape Power"));
            AllCardItems.Add(new CardItem(605, "Gatling Pea"));
            AllCardItems.Add(new CardItem(606, "Tricorn"));
            AllCardItems.Add(new CardItem(607, "Jelly Bean"));
            AllCardItems.Add(new CardItem(608, "Lima-Pleurodon"));
            AllCardItems.Add(new CardItem(609, "Kernel-Pult"));
            AllCardItems.Add(new CardItem(610, "Elderberry"));
            AllCardItems.Add(new CardItem(611, "Primal Sunflower"));
            AllCardItems.Add(new CardItem(612, "Sunflower Seed"));
            AllCardItems.Add(new CardItem(614, "Ancient Vimpire"));
            AllCardItems.Add(new CardItem(619, "Parasol Zombie"));
            AllCardItems.Add(new CardItem(620, "Gargantuar Mime"));
            AllCardItems.Add(new CardItem(621, "Evolutionary Leap"));
            AllCardItems.Add(new CardItem(624, "Zombie Middle Manager"));
            AllCardItems.Add(new CardItem(626, "Jurassic Fossilhead"));
            AllCardItems.Add(new CardItem(628, "Barrel of Barrels"));
            AllCardItems.Add(new CardItem(629, "Blowgun Imp"));
            AllCardItems.Add(new CardItem(631, "Zombot Aerostatic Gondola"));
            AllCardItems.Add(new CardItem(633, "Grave Mistake"));
            AllCardItems.Add(new CardItem(634, "Fireweed"));
            AllCardItems.Add(new CardItem(636, "Cob Cannon"));
            AllCardItems.Add(new CardItem(638, "Witch Hazel"));
            AllCardItems.Add(new CardItem(639, "Ketchup Mechanic"));
            AllCardItems.Add(new CardItem(640, "Fraidy Cat"));
            AllCardItems.Add(new CardItem(641, "Exploding Fruitcake"));
            AllCardItems.Add(new CardItem(642, "Sneezing Zombie"));
            AllCardItems.Add(new CardItem(643, "Unexpected Gifts"));
            AllCardItems.Add(new CardItem(645, "Pumpkin Shell"));
            AllCardItems.Add(new CardItem(646, "Primal Wall-Nut"));
            AllCardItems.Add(new CardItem(649, "Shelf Mushroom"));
            AllCardItems.Add(new CardItem(650, "Strawberrian"));
            AllCardItems.Add(new CardItem(653, "Typical Beanstalk"));
            AllCardItems.Add(new CardItem(655, "Pea Patch"));
            AllCardItems.Add(new CardItem(656, "Savage Spinach"));
            AllCardItems.Add(new CardItem(657, "Apotatosaurus"));
            AllCardItems.Add(new CardItem(658, "Primal Peashooter"));
            AllCardItems.Add(new CardItem(660, "Rotobaga"));
            AllCardItems.Add(new CardItem(662, "Bird of Paradise"));
            AllCardItems.Add(new CardItem(664, "Eyespore"));
            AllCardItems.Add(new CardItem(665, "Aloesaurus"));
            AllCardItems.Add(new CardItem(666, "Killer Whale"));
            AllCardItems.Add(new CardItem(667, "Hunting Grounds"));
            AllCardItems.Add(new CardItem(669, "Gargantuar-Throwing Gargantuar"));
            AllCardItems.Add(new CardItem(670, "Mustache Waxer"));
            AllCardItems.Add(new CardItem(672, "Mustache Monument"));
            AllCardItems.Add(new CardItem(674, "Zombot Dinotronic Mechasaur"));
            AllCardItems.Add(new CardItem(675, "Disco Dance Floor"));
            AllCardItems.Add(new CardItem(676, "Zombie's Best Friend"));
            AllCardItems.Add(new CardItem(679, "Turquoise Skull Zombie"));
            AllCardItems.Add(new CardItem(681, "Grave Robber"));
            AllCardItems.Add(new CardItem(683, "Excavator Zombie"));
            AllCardItems.Add(new CardItem(684, "Buried Treasure"));
            AllCardItems.Add(new CardItem(688, "Frankentuar"));
            AllCardItems.OrderBy(x => x.Value);
            EditableDeck.AllCardItems = AllCardItems.ToList();
            CardList.DataSource = CurrentCardItems;
            CardList.DisplayMember = "Name";
            CardList.ValueMember = "Value";
        }
        void InitializeDeck()
        {
            DeckListView.DataSource = BindingCards;
            DeckListView.DisplayMember = "Name";
            DeckListView.ValueMember = "Value";
        }

        private void CardSearch_TextChanged(object sender, EventArgs e)
        {
            CurrentCardItems.Clear();
            foreach (CardItem card in AllCardItems)
            {
                string cardName = card.Name.ToLower();
                string searchText = CardSearch.Text.ToLower();
                if (CardSearch.Text != "" && cardName.Contains(searchText)) CurrentCardItems.Add(card);
            }
            CardList.SelectedItem = null;
        }

        private void SearchCardLabel_Click(object sender, EventArgs e)
        {

        }

        private void CardAdder_Click(object sender, EventArgs e)
        {
            if (SelectedAddedCard > 0)
            {
                Deck.CardIds.Add(SelectedAddedCard);
                DeckUpdate();
            }
        }
        List<int> StoredUniqueCards = [];

        bool UniqueCardsChanged()
        {
            if (StoredUniqueCards.Count == 0) return true;
            if (Deck.UniqueCards().Count != StoredUniqueCards.Count) return true;
            foreach (int card in StoredUniqueCards)
            {
                if (!Deck.UniqueCards().Exists(x => x == card)) return true;
            }
            return false;
        }
        private void DeckUpdate()
        {
            Deck.CardIds.Sort();
            CopiesList.Items.Clear();
            foreach (int card in Deck.UniqueCards())
            {
                CopiesList.Items.Add("×" + Deck.CopiesOfCard(card).ToString());
            }
            CardCount.Text = Deck.CardIds.Count.ToString();
            if (UniqueCardsChanged())
            {
                BindingCards.Clear();
                foreach (int card in Deck.UniqueCards())
                {
                    BindingCards.Add(new CardItem(card, EditableDeck.CardName(card)));
                }
                StoredUniqueCards = new List<int>(Deck.UniqueCards());
                DeckListView.SelectedItem = null;
            }
        }
        BindingList<CardItem> BindingCards { get; set; } = [];

        private void CardRemover_Click(object sender, EventArgs e)
        {
            if (SelectedRemovedCard > 0 && Deck.CardIds.Contains(SelectedRemovedCard))
            {
                Deck.CardIds.Remove(SelectedRemovedCard);
                DeckUpdate();
            }
        }

        private void DeckListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeckListView.SelectedValue != null) SelectedRemovedCard = (int)DeckListView.SelectedValue;
            else SelectedRemovedCard = -1;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure? All unsaved data will be lost!",
                "New Deck", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Deck.CardIds.Clear();
                DeckSaver.FileName = "";
                DeckUpdate();
            }
        }
    }
    public class CardItem
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public CardItem(int value, string name)
        {
            Name = name;
            Value = value;
        }
    }
}
