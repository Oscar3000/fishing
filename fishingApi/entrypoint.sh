#!/bin/bash

set -e
#run_cmd="dotnet fishingApi.dll"
#run_cmd="dotnet run --server.urls http://*:80"
run_cmd="dotnet run"

until dotnet ef database update; do
>&2 echo "SQL Server is starting up"
sleep 1
done

>&2 echo "SQL Server is up - executing command"
exec $run_cmd