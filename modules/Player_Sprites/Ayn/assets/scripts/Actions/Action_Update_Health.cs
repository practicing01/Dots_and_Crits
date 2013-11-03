function Module_Player_Sprite_Ayn::Action_Update_Health(%this,%Player_Information,%Target_Player_Game_Connection_Handle,%Operation,%Amount)
{

%Target_Player=0;

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Target_Player=%this.Simset_Player_Information.getObject(%x);

if (%Target_Player.Game_Connection_Handle==%Target_Player_Game_Connection_Handle)
{

break;

}

%Target_Player=0;

}

if (!%Target_Player){return;}

if (%Operation==0)//Add
{

%Target_Player.Health+=%Amount;

}
else if (%Operation==1)//Subtract
{

%Target_Player.Health-=%Amount;

}
else//Set
{

%Target_Player.Health=%Amount;

}

echo(%Target_Player.Game_Connection_Handle SPC %Target_Player.Health);//banana
$Module_ID_Map_Loaded.Player_Health(%Target_Player);

}
