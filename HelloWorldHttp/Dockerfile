FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
COPY . .
RUN dotnet publish \
    --runtime alpine-x64 \
    --self-contained true \
    /p:PublishSingleFile=true \
    /p:PublishTrimmed=true \
    -c Release \
    -o ./out \
    HelloWorldHttp

FROM mcr.microsoft.com/dotnet/core/runtime-deps:3.1-alpine
RUN adduser \
    --disabled-password \
    --home /app \
    --gecos '' app \
    && chown -R app /app
USER app
WORKDIR /app
COPY --from=build-env /app/out .
CMD /app/HelloWorldHttp
