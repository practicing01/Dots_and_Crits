function Module_Card_NPC_Wyvern::Action_Position(%this,%Player_Information,%Unit_Game_Connection_Handle,%Unit_Object_Index,%Vector_2D_Position)
{

%Unit=-1;

for (%x=0;%x<%this.Simset_Objects.getCount();%x++)
{

%Unit=%this.Simset_Objects.getObject(%x);

if (%Unit.Game_Connection_Handle==%Unit_Game_Connection_Handle&&%Unit.Object_Index==%Unit_Object_Index)
{

break;

}

%Unit=-1;

}

if (!isObject(%Unit)){return;}

%Unit.Position=%Vector_2D_Position;

}
