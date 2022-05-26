FROM node:16.0-alpine AS build
EXPOSE 4200
WORKDIR /usr/src/app
COPY package.json package-lock.json ./
RUN npm install -g npm@8.11.0 -g @angular/cli
COPY . .
RUN npm run build
