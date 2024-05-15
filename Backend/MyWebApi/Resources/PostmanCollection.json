{
	"info": {
		"_postman_id": "ba98f660-a427-46f9-8647-c01230e6ccd3",
		"name": "Client Manager App",
		"schema": "https://schema.getpostman.com/json/collection/v2.1.0/collection.json",
		"_exporter_id": "16558781"
	},
	"item": [
		{
			"name": "Authentication",
			"request": {
				"method": "POST",
				"header": [],
				"body": {
					"mode": "raw",
					"raw": "{\n  \"userName\": \"jane_smith\",\n  \"password\": \"pass2\"\n}",
					"options": {
						"raw": {
							"language": "json"
						}
					}
				},
				"url": {
					"raw": "http://localhost:5084/api/Auth",
					"protocol": "http",
					"host": [
						"localhost"
					],
					"port": "5084",
					"path": [
						"api",
						"Auth"
					]
				}
			},
			"response": []
		},
		{
			"name": "Create client",
			"request": {
				"auth": {
					"type": "bearer",
					"bearer": [
						{
							"key": "token",
							"value": "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiamFuZV9zbWl0aCIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6ImNvbnN1bHRhbnQiLCJuYmYiOjE3MTU3OTA3OTcsImV4cCI6MTcxNTc5MTM5N30.sf0Go7TIh9yI3p6v2lbdmxMK8MvcEJA8WGivPoizx00",
							"type": "string"
						}
					]
				},
				"method": "POST",
				"header": [],
				"body": {
					"mode": "raw",
					"raw": "{\n  \"name\": \"A Name\",\n  \"lastname\": \"A Lastname\",\n  \"accountNumber\": \"QWE123890\",\n  \"balance\": 0,\n  \"dateOfBirth\": \"2024-05-15T03:59:14.090Z\",\n  \"address\": \"An address\",\n  \"phone\": \"555-246\",\n  \"email\": \"email.example@some.com\",\n  \"clientType\": \"corporate\",\n  \"maritalStatus\": \"single\",\n  \"identificationNumber\": \"ID098123567\",\n  \"profession\": \"Developer\",\n  \"gender\": \"Male\",\n  \"nationality\": \"Colombian\"\n}",
					"options": {
						"raw": {
							"language": "json"
						}
					}
				},
				"url": {
					"raw": "http://localhost:5084/api/Clients",
					"protocol": "http",
					"host": [
						"localhost"
					],
					"port": "5084",
					"path": [
						"api",
						"Clients"
					]
				}
			},
			"response": []
		},
		{
			"name": "Get all clients",
			"request": {
				"auth": {
					"type": "bearer",
					"bearer": [
						{
							"key": "token",
							"value": "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiam9obl9kb2UiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJhZG1pbiIsIm5iZiI6MTcxNTc5MDU4NywiZXhwIjoxNzE1NzkxMTg3fQ.O4WXwZpssmNg6j8y9XDyLDlTlgTijZ8XGsVOxYgTu5A",
							"type": "string"
						}
					]
				},
				"method": "GET",
				"header": [],
				"url": {
					"raw": "http://localhost:5084/api/Clients",
					"protocol": "http",
					"host": [
						"localhost"
					],
					"port": "5084",
					"path": [
						"api",
						"Clients"
					]
				}
			},
			"response": []
		},
		{
			"name": "Get client by id",
			"request": {
				"auth": {
					"type": "bearer",
					"bearer": [
						{
							"key": "token",
							"value": "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiam9obl9kb2UiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJhZG1pbiIsIm5iZiI6MTcxNTc5MDU4NywiZXhwIjoxNzE1NzkxMTg3fQ.O4WXwZpssmNg6j8y9XDyLDlTlgTijZ8XGsVOxYgTu5A",
							"type": "string"
						}
					]
				},
				"method": "GET",
				"header": [],
				"url": {
					"raw": "http://localhost:5084/api/Clients/2",
					"protocol": "http",
					"host": [
						"localhost"
					],
					"port": "5084",
					"path": [
						"api",
						"Clients",
						"2"
					]
				}
			},
			"response": []
		},
		{
			"name": "Update client",
			"request": {
				"auth": {
					"type": "bearer",
					"bearer": [
						{
							"key": "token",
							"value": "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiam9obl9kb2UiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJhZG1pbiIsIm5iZiI6MTcxNTc5MDU4NywiZXhwIjoxNzE1NzkxMTg3fQ.O4WXwZpssmNg6j8y9XDyLDlTlgTijZ8XGsVOxYgTu5A",
							"type": "string"
						}
					]
				},
				"method": "PUT",
				"header": [],
				"body": {
					"mode": "raw",
					"raw": "{\n  \"name\": \"A Name\",\n  \"lastname\": \"A Lastname\",\n  \"accountNumber\": \"QWE123890\",\n  \"balance\": 1000,\n  \"dateOfBirth\": \"2024-05-15T03:59:14.090Z\",\n  \"address\": \"An address\",\n  \"phone\": \"555-246\",\n  \"email\": \"email.example@some.com\",\n  \"clientType\": \"corporate\",\n  \"maritalStatus\": \"single\",\n  \"identificationNumber\": \"ID098123567\",\n  \"profession\": \"Developer\",\n  \"gender\": \"Male\",\n  \"nationality\": \"Colombian\"\n}",
					"options": {
						"raw": {
							"language": "json"
						}
					}
				},
				"url": {
					"raw": "http://localhost:5084/api/Clients/7",
					"protocol": "http",
					"host": [
						"localhost"
					],
					"port": "5084",
					"path": [
						"api",
						"Clients",
						"7"
					]
				}
			},
			"response": []
		},
		{
			"name": "Delete client",
			"request": {
				"auth": {
					"type": "bearer",
					"bearer": [
						{
							"key": "token",
							"value": "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiamFuZV9zbWl0aCIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6ImNvbnN1bHRhbnQiLCJuYmYiOjE3MTU3OTA3OTcsImV4cCI6MTcxNTc5MTM5N30.sf0Go7TIh9yI3p6v2lbdmxMK8MvcEJA8WGivPoizx00",
							"type": "string"
						}
					]
				},
				"method": "DELETE",
				"header": [],
				"url": {
					"raw": "http://localhost:5084/api/Clients/7",
					"protocol": "http",
					"host": [
						"localhost"
					],
					"port": "5084",
					"path": [
						"api",
						"Clients",
						"7"
					]
				}
			},
			"response": []
		}
	]
}