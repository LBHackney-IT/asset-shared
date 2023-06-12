.PHONY: clean
clean:
	docker rm $$(docker ps -a --filter "status=exited" | grep hackney-shared-asset-test | grep -oE "^[[:xdigit:]]+")
	docker rmi $$(docker images --filter "dangling=true" -q)

.PHONY: test
test:
	-docker-compose build hackney-shared-asset-test && docker-compose run hackney-shared-asset-test
	-make clean
