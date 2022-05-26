FROM node:16.0-alpine AS build
EXPOSE 4200
COPY AosoFront/package*.json ./
WORKDIR /usr/src/app
COPY ./ /usr/src/app/
RUN npm install
RUN npm run build

