function Class_Toggle_Portal_Bearer_Projectile::onResize(%this)
{

%this.clearCollisionShapes();

%Radius=0;

if (%this.Size.X>%this.Size.Y){%Radius=%this.Size.X/2;}else{%Radius=%this.Size.Y/2;}

%Collision_Shape_Index=%this.createCircleCollisionShape(%Radius);

%this.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

}
