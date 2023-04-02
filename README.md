# Blazor Template

## 인증서 신뢰하기

dotnet dev-certs https --trust

## 개발

- dotnet watch

## 패키지 설치

- `dotnet add package xxx` (ex: MudBlazor)

## Docker 환경설정

- `docker compose up -detach` or `docker compose up -d`

## Docker 환경 삭제

- `docker compose down`
- `-v` 옵션 추가시 볼륨까지 삭제

## EF Core Create New Migration

- `dotnet ef migrations add Xxx` (ex: InitialCreate)


## EF Core Undo Previous Migration

- `ef migrations remove`

## EF Core Apply Migration

- `dotnet ef database update`

## EF Core Apply Migration Drop

- `dotnet ef database drop`

## 빌드 및 실행

- `dotnet publish`
- `./bin/Debug/net7.0/publish/BlazorTemplate`