extends Node

@export var recevier: Recevier
var timer: float = 5.0;

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	print("Hello Friend")
	print(recevier.onCalled())


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	if timer <= 0:
		timer = 5.0
		print("Hello Friend")
		print(recevier.onCalled())
	timer -= delta
