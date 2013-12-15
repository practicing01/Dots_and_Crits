function Class_Deus_Ex_Telum_Mech::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%this.Health<=0){return;}

if (%Colliding_Object.class$="Class_Deus_Ex_Telum_Microwave"){return;}

%Distance_X=mAbs(%this.Position.X-%Colliding_Object.Position.X);

%Distance_Y=mAbs(%this.Position.Y-%Colliding_Object.Position.Y);

if (%Distance_X<%Distance_Y)
{

if (%this.Direction.Y==1)
{

%this.Direction.Y=-1;

%this.setLinearVelocityY(%this.Direction.Y*%this.Current_Speed);

if (%this.Image$="Module_Map_Deus_Ex_Telum:Image_Mech")
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Down");

/*if (%this.Direction.X==-1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Down_Left");

}
else if (%this.Direction.X==1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Down_Right");

}*/

}
else if (%this.Image$="Module_Map_Deus_Ex_Telum:Image_Mech0")
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Down");

/*if (%this.Direction.X==-1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Down_Left");

}
else if (%this.Direction.X==1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Down_Right");

}*/

}
else
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Down");

/*if (%this.Direction.X==-1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Down_Left");

}
else if (%this.Direction.X==1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Down_Right");

}*/

}

}
else
{

%this.Direction.Y=1;

%this.setLinearVelocityY(%this.Direction.Y*%this.Current_Speed);

if (%this.Image$="Module_Map_Deus_Ex_Telum:Image_Mech")
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Up");

/*if (%this.Direction.X==-1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Up_Left");

}
else if (%this.Direction.X==1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Up_Right");

}*/

}
else if (%this.Image$="Module_Map_Deus_Ex_Telum:Image_Mech0")
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Up");

/*if (%this.Direction.X==-1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Up_Left");

}
else if (%this.Direction.X==1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Up_Right");

}*/

}
else
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Up");

/*if (%this.Direction.X==-1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Up_Left");

}
else if (%this.Direction.X==1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Up_Right");

}*/

}

}

}
else
{

if (%this.Direction.X==1)
{

%this.Direction.X=-1;

%this.setLinearVelocityX(%this.Direction.X*%this.Current_Speed);

if (%this.Image$="Module_Map_Deus_Ex_Telum:Image_Mech")
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Left");

/*if (%this.Direction.Y==-1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Up_Left");

}
else if (%this.Direction.Y==1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Down_Left");

}*/

}
else if (%this.Image$="Module_Map_Deus_Ex_Telum:Image_Mech0")
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Left");

/*if (%this.Direction.Y==-1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Up_Left");

}
else if (%this.Direction.Y==1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Down_Left");

}*/

}
else
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Left");

/*if (%this.Direction.Y==-1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Up_Left");

}
else if (%this.Direction.Y==1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Down_Left");

}*/

}

}
else
{

%this.Direction.X=1;

%this.setLinearVelocityX(%this.Direction.X*%this.Current_Speed);

if (%this.Image$="Module_Map_Deus_Ex_Telum:Image_Mech")
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Right");

/*if (%this.Direction.Y==-1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Up_Right");

}
else if (%this.Direction.Y==1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Down_Right");

}*/

}
else if (%this.Image$="Module_Map_Deus_Ex_Telum:Image_Mech0")
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Right");

/*if (%this.Direction.Y==-1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Up_Right");

}
else if (%this.Direction.Y==1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Down_Right");

}*/

}
else
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Right");

/*if (%this.Direction.Y==-1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Up_Right");

}
else if (%this.Direction.Y==1)
{

%this.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Down_Right");

}*/

}

}

}

}
