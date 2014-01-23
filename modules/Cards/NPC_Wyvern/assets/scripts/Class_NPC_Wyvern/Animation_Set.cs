function Class_NPC_Wyvern::Animation_Set(%this,%String_Animation)
{

if (%String_Animation$="Breath")
{

if (%this.Vector_2D_Direction.X==0)//X is neutral, going up or down.
{

if (%this.Vector_2D_Direction.Y==-1)//Down.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Breath_Down");

}
else if (%this.Vector_2D_Direction.Y==1)//Up.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Breath_Up");

}

}
else if (%this.Vector_2D_Direction.X==-1)//Left.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Breath_Left");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Breath_Down_Left");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Breath_Up_Left");

}

}
else if (%this.Vector_2D_Direction.X==1)//Right.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Breath_Right");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Breath_Down_Right");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Breath_Up_Right");

}

}

}
else if (%String_Animation$="Die")
{

if (%this.Vector_2D_Direction.X==0)//X is neutral, going up or down.
{

if (%this.Vector_2D_Direction.Y==-1)//Down.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Die_Down");

}
else if (%this.Vector_2D_Direction.Y==1)//Up.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Die_Up");

}

}
else if (%this.Vector_2D_Direction.X==-1)//Left.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Die_Left");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Die_Down_Left");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Die_Up_Left");

}

}
else if (%this.Vector_2D_Direction.X==1)//Right.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Die_Right");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Die_Down_Right");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Die_Up_Right");

}

}

}
else if (%String_Animation$="Fly")
{

if (%this.Vector_2D_Direction.X==0)//X is neutral, going up or down.
{

if (%this.Vector_2D_Direction.Y==-1)//Down.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Fly_Down");

}
else if (%this.Vector_2D_Direction.Y==1)//Up.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Fly_Up");

}

}
else if (%this.Vector_2D_Direction.X==-1)//Left.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Fly_Left");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Fly_Down_Left");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Fly_Up_Left");

}

}
else if (%this.Vector_2D_Direction.X==1)//Right.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Fly_Right");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Fly_Down_Right");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Fly_Up_Right");

}

}

}
else if (%String_Animation$="Hit")
{

if (%this.Vector_2D_Direction.X==0)//X is neutral, going up or down.
{

if (%this.Vector_2D_Direction.Y==-1)//Down.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hit_Down");

}
else if (%this.Vector_2D_Direction.Y==1)//Up.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hit_Up");

}

}
else if (%this.Vector_2D_Direction.X==-1)//Left.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hit_Left");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hit_Down_Left");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hit_Up_Left");

}

}
else if (%this.Vector_2D_Direction.X==1)//Right.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hit_Right");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hit_Down_Right");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hit_Up_Right");

}

}

}
else if (%String_Animation$="Hover")
{

if (%this.Vector_2D_Direction.X==0)//X is neutral, going up or down.
{

if (%this.Vector_2D_Direction.Y==-1)//Down.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hover_Down");

}
else if (%this.Vector_2D_Direction.Y==1)//Up.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hover_Up");

}

}
else if (%this.Vector_2D_Direction.X==-1)//Left.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hover_Left");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hover_Down_Left");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hover_Up_Left");

}

}
else if (%this.Vector_2D_Direction.X==1)//Right.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hover_Right");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hover_Down_Right");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Hover_Up_Right");

}

}

}
else if (%String_Animation$="Ram")
{

if (%this.Vector_2D_Direction.X==0)//X is neutral, going up or down.
{

if (%this.Vector_2D_Direction.Y==-1)//Down.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Ram_Down");

}
else if (%this.Vector_2D_Direction.Y==1)//Up.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Ram_Up");

}

}
else if (%this.Vector_2D_Direction.X==-1)//Left.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Ram_Left");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Ram_Down_Left");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Ram_Up_Left");

}

}
else if (%this.Vector_2D_Direction.X==1)//Right.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Ram_Right");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Ram_Down_Right");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Ram_Up_Right");

}

}

}
else if (%String_Animation$="Sting")
{

if (%this.Vector_2D_Direction.X==0)//X is neutral, going up or down.
{

if (%this.Vector_2D_Direction.Y==-1)//Down.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Sting_Down");

}
else if (%this.Vector_2D_Direction.Y==1)//Up.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Sting_Up");

}

}
else if (%this.Vector_2D_Direction.X==-1)//Left.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Sting_Left");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Sting_Down_Left");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-left.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Sting_Up_Left");

}

}
else if (%this.Vector_2D_Direction.X==1)//Right.
{

if (%this.Vector_2D_Direction.Y==0)//Y is neutral, going right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Sting_Right");

}
else if (%this.Vector_2D_Direction.Y==-1)//Down-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Sting_Down_Right");

}
else if (%this.Vector_2D_Direction.Y==1)//Up-right.
{

%this.playAnimation("Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Sting_Up_Right");

}

}

}

}
