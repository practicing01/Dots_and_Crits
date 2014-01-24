function Module_Card_Laser::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%World_Position)
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

if (%Target_Player==0)
{

%Target_Player=new ScriptObject()
{

Game_Connection_Handle=0;

};

}

//Use player info to play animations.

//This skill only allows for the client who cast to have the mounted sprite.
//Targeting itself will toggle the sprite, any other target will be attacked.

%Player_Object=0;

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Simset_Player_Information.getObject(%x);

if (%Player_Object.Player_Information.Game_Connection_Handle==%Player_Information.Game_Connection_Handle)
{

break;

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0)//New Laser user.
{

%Script_Object_Player_Information=new ScriptObject()
{

Player_Information=%Player_Information;

Sprite_Laser=0;

Sprite_Laser_Beam=0;

Schedule_Laser_Beam=0;

};

%Vector_2D_Laser_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Laser);

%Script_Object_Player_Information.Sprite_Laser=new Sprite()
{

BodyType="static";
size=%Vector_2D_Laser_Size;
Image="Module_Card_Laser:Image_Laser";
Position="0 0";

};

%this.Simset_Player_Information.add(%Script_Object_Player_Information);

Scene_Dots_and_Crits.add(%Script_Object_Player_Information.Sprite_Laser);

%Vector_2D_Player_Size=%Player_Information.Player_Sprite_Data.Sprite.getSize();

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Player_Size.Y/2)+(%Vector_2D_Laser_Size.Y/2);

%Script_Object_Player_Information.Sprite_Laser.mount(%Player_Information.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(315));

%Bool_Already_Registered_For_Dismount=false;

for (%y=0;%y<%Player_Information.Player_Sprite_Data.Simset_Objects_To_Dismount.getCount();%y++)
{

%Mounted_Object=%Player_Information.Player_Sprite_Data.Simset_Objects_To_Dismount.getObject(%y);

if (%Mounted_Object==%Script_Object_Player_Information.Sprite_Laser)
{

%Bool_Already_Registered_For_Dismount=true;

break;

}

}

if (!%Bool_Already_Registered_For_Dismount)
{

%Player_Information.Player_Sprite_Data.Simset_Objects_To_Dismount.add(%Script_Object_Player_Information.Sprite_Laser);

}

/****************************************/

%Vector_2D_Laser_Beam_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Laser_Beam);

%Script_Object_Player_Information.Sprite_Laser_Beam=new Sprite()
{

BodyType="static";
size=%Vector_2D_Laser_Beam_Size;
Image="Module_Card_Laser:Image_Laser_Beam";
Position="0 0";
Visible=false;

BlendColor="1 1 1 0.5";

class="Class_Laser";

SleepingAllowed=false;

Game_Connection_Handle=%Player_Information.Game_Connection_Handle;

};

%this.Simset_Player_Information.add(%Script_Object_Player_Information);

Scene_Dots_and_Crits.add(%Script_Object_Player_Information.Sprite_Laser_Beam);

/****************************************/

}
else
{

if (%Player_Object.Sprite_Laser.Visible)
{

if (%Target_Player.Game_Connection_Handle==%Player_Information.Game_Connection_Handle)
{

%Player_Object.Sprite_Laser.Visible=false;

%Player_Object.Sprite_Laser_Beam.Visible=false;

cancel(%Player_Object.Schedule_Laser_Beam);

%Player_Object.Schedule_Laser_Beam=0;

}
else
{

%Player_Object.Sprite_Laser_Beam.Visible=true;

cancel(%Player_Object.Schedule_Laser_Beam);

%Player_Object.Schedule_Laser_Beam=schedule(0,0,"Module_Card_Laser::Update_Laser_Beam",%this,%Player_Object,%World_Position);

}

}
else
{

%Player_Object.Sprite_Laser.Visible=true;

}

}

}
