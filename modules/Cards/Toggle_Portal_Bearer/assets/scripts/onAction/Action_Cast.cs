function Module_Card_Toggle_Portal_Bearer::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle)
{

%Target_Player=0;

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==%Player_Sprite_Target_Game_Connection_Handle)
{

%Target_Player=%Player_Object;

break;

}

}

if (%Target_Player==0){return;}

//Use player info to play animations.

%Player_Object=0;

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Simset_Player_Information.getObject(%x);

if (%Player_Object.Player_Information.Game_Connection_Handle==%Target_Player.Game_Connection_Handle)
{

break;

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0)//New Toggle_Portal_Bearer user.
{

%Script_Object_Player_Information=new ScriptObject()
{

Player_Information=%Target_Player;

Bool_Toggle_Portal_Bearer=true;

Simset_Previous_Portal=0;

};

%Script_Object_Player_Information.Simset_Previous_Portal=new SimSet();

%this.Simset_Player_Information.add(%Script_Object_Player_Information);

if (%Target_Player.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

%this.Player_Information_This=%Script_Object_Player_Information;

}

}
else
{

if (%Player_Object.Bool_Toggle_Portal_Bearer)
{

%Player_Object.Bool_Toggle_Portal_Bearer=false;

}
else
{

%Player_Object.Bool_Toggle_Portal_Bearer=true;

}

}

}
