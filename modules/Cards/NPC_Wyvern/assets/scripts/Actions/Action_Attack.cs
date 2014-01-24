function Module_Card_NPC_Wyvern::Action_Attack(%this,%Player_Information,%Object_Module_ID,%Object_Game_Connection_Handle,%Object_Index,%Unit_Object_Index,%Attack)
{

%Script_Object_Player=%Player_Information.Player_Sprite_Data.Sprite.Script_Object_Parent;

%Sprite_Unit=-1;

for (%x=0;%x<%this.Simset_Objects.getCount();%x++)
{

%Object=%this.Simset_Objects.getObject(%x);

if (%Object.Object_Index==%Unit_Object_Index&&%Object.Game_Connection_Handle==%Player_Information.Game_Connection_Handle)
{

%Sprite_Unit=%Object;

break;

}

}

if (!isObject(%Sprite_Unit)){return;}

/*******************************************************************/


if (%Attack==0)
{

%Sprite_Unit.Animation_Set("Sting");

//Go through object's module if the object exists based on game connection handle.

if (!isObject(%Object_Module_ID)){return;}

if (%Object_Index==-1)//Player being attacked.
{

for (%x=0;%x<%Object_Module_ID.Simset_Player_Information.getCount();%x++)
{

%Object=%Object_Module_ID.Simset_Player_Information.getObject(%x);

if (%Object.Game_Connection_Handle==%Object_Game_Connection_Handle)
{

%Object_Module_ID.Action_Update_Health(%Object,%Object.Game_Connection_Handle,1,%Sprite_Unit.Current_Attack);

break;

}

}

}
else
{

for (%x=0;%x<%Object_Module_ID.Simset_Objects.getCount();%x++)
{

%Object=%Object_Module_ID.Simset_Objects.getObject(%x);

if (%Object.Game_Connection_Handle==%Object_Game_Connection_Handle&&%Object.Object_Index==%Object_Index)
{

%Object_Module_ID.Action_Update_Health(%Player_Information,%Object.Game_Connection_Handle,%Object.Object_Index,1,%Sprite_Unit.Current_Attack);

break;

}

}

}

}
else if (%Attack==1)
{



}

}
