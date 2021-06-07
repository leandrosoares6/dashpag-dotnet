start:
	docker-compose up -d

start-dev:
	docker-compose -f docker-compose.dev.yaml up -d

build:
	docker-compose up -d --build

build-dev:
	docker-compose -f docker-compose.dev.yaml up -d --build

down:
	docker-compose down

down-dev:
	docker-compose -f docker-compose.dev.yaml down

app-logs:
	docker-compose logs -f app

db-logs:
	docker-compose logs -f db

app-logs-dev:
	docker-compose -f docker-compose.dev.yaml logs -f app

db-logs-dev:
	docker-compose -f docker-compose.dev.yaml logs -f db


down-rmi:
	docker-compose down --rmi local

clean: down-rmi
	@echo "💥 Removing related folders/files..."
	@sudo rm -rf  ./.docker/dbdata/*

reset: clean