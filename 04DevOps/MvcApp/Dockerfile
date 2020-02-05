FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

WORKDIR /app

COPY . ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app

COPY --from=build /app/out ./

CMD dotnet MvcApp.dll


# docker run options:

# "-it" will attach the container to the current terminal,
#    so that Ctrl+C will stop the container too.
# "-d" will detach the container from the current terminal,
#   it will stay running in the background.
# "--rm" will clean up the container once it stops.



# example: docker run -it --rm -p 5000:80 -e "ConnectionStrings__MyDb=Server=blahblah;" mvcapp:1.0
