function Class_NPC_Wyvern::onResize(%this)
{

%this.clearCollisionShapes();

%Square_Size=%this.Size;

%Square_Size.X/=3;

%Square_Size.Y/=3;

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%this.createCircleCollisionShape(%Radius);

%Square_Size.X*=6;

%Square_Size.Y*=6;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Collision_Shape_Index=%this.createCircleCollisionShape(%Radius);

%this.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

}
