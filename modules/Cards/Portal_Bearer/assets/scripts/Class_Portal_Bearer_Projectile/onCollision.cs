function Class_Portal_Bearer_Projectile::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Composite_Sprite_Player")
{

if (%Colliding_Object.Script_Object_Parent.Game_Connection_Handle!=%this.Game_Connection_Handle)
{

/*************************************/

%Player_Object=0;

for (%x=0;%x<%this.Module_ID_Parent.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Module_ID_Parent.Simset_Player_Information.getObject(%x);

if (%Player_Object.Player_Information.Game_Connection_Handle==%this.Game_Connection_Handle)
{

break;

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0)
{

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

return;

}

/*************************************/

if (!%this.Bool_Portal_Projectile_Type)//In
{

%Player_Object.Sprite_Portal_In.Angle=(%this.Angle+270)%360;

%Player_Object.Sprite_Portal_In.Position=%this.Position;

%Player_Object.Sprite_Portal_In.Visible=true;

}
else
{

%Player_Object.Sprite_Portal_Out.Angle=(%this.Angle+270)%360;

%Player_Object.Sprite_Portal_Out.Position=%this.Position;

%Player_Object.Sprite_Portal_Out.Visible=true;

}

/*************************************/

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

}

}
else if (%Colliding_Object.Game_Connection_Handle!=%this.Game_Connection_Handle)
{

/*************************************/

%Player_Object=0;

for (%x=0;%x<%this.Module_ID_Parent.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Module_ID_Parent.Simset_Player_Information.getObject(%x);

if (%Player_Object.Player_Information.Game_Connection_Handle==%this.Game_Connection_Handle)
{

break;

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0)
{

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

return;

}

/*************************************/

if (!%this.Bool_Portal_Projectile_Type)//In
{

%Player_Object.Sprite_Portal_In.Angle=(%this.Angle+270)%360;

%Player_Object.Sprite_Portal_In.Position=%this.Position;

%Player_Object.Sprite_Portal_In.Visible=true;

}
else
{

%Player_Object.Sprite_Portal_Out.Angle=(%this.Angle+270)%360;

%Player_Object.Sprite_Portal_Out.Position=%this.Position;

%Player_Object.Sprite_Portal_Out.Visible=true;

}

/*************************************/

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

}

}
