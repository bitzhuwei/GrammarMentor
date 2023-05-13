#version 150

uniform vec3 ambientColor;

out vec4 outColor;

void main() {
	outColor = vec4(ambientColor, 1.0);
}

