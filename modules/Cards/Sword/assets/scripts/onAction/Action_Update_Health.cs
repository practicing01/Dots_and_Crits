function Module_Card_Sword::Action_Update_Health(%this,%Player_Information,%Unit_Game_Connection_Handle,%Unit_Object_Index,%Operation,%Amount)
{

%Player_Object=0;

%Unit=-1;

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Simset_Player_Information.getObject(%x);

if (%Player_Object.Player_Information.Game_Connection_Handle==%Unit_Game_Connection_Handle)
{

if (%Player_Object.Player_Information.Sprite_Sword.Object_Index==%Unit_Object_Index)
{

%Unit=%Player_Object.Player_Information.Sprite_Sword;

break;

}

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0){return;}

if (!isObject(%Unit)){return;}

if (%Operation==0)//Add
{

%Unit.Health+=%Amount;

}
else if (%Operation==1)//Subtract
{

%Unit.Health-=%Amount;

}
else//Set
{

%Unit.Health=%Amount;

}

%Unit.Update_Health();

}
