FROM ghcr.io/architecture-it/net:3.1-sdk as build
WORKDIR /app
COPY . .
RUN dotnet restore
WORKDIR "/app/src/Api"
RUN dotnet build "CliDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CliDemo.csproj" -c Release -o /app/publish

FROM ghcr.io/architecture-it/net:3.1
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "CliDemo.dll"]
