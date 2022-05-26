FROM node:alpine AS build
EXPOSE 4200
WORKDIR /usr/src/app
COPY ./ /usr/src/app/
RUN npm install
RUN npm run build

