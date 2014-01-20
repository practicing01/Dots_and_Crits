//Global variables are noobish, need to get rid of them eventually

/*Misc*/

/*Simset to hold schedules so that they can be cancelled*/
$Simset_Cancelable_Schedules_Global=new SimSet();

$Simset_Cancelable_Schedules_Skills=new SimSet();

$Resolution=$pref::Video::defaultResolution;//"800 480";

/*Is this bugged? Should it be only from 0-30??*/
$All_Bits="0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31";

$Pie=3.14;

/*Audio*/

$Bool_Music_On=true;

/*Network*/

$Simset_Players_Information=new SimSet();

$Simset_Module_ID_Loaded_Player_Sprites=0;

$Simset_Loaded_Card_Modules=new SimSet();

$Simset_Live_Clients=0;

/*Cards*/

$Simset_Cards_To_Load=new SimSet();

/*Maps*/

$String_Map_To_Load="Deathball Valley";

$Simset_ModuleID_Maps=0;

$Module_ID_Map_Loaded=0;

/*This clients player settings*/

$String_Player_Sprite="Ayn";

$Bool_Is_Playing=false;

$String_Client_Name="Dots & Crits Client";

$ScriptObject_Player_Information_This=0;

/*Player Sprites*/

$Simset_ModuleID_Player_Sprites=0;

/*Decks*/

$Simset_Deck_To_Load=0;

/*Gui*/

$Simset_Unfocused_Guis_To_Pop=new SimSet();
