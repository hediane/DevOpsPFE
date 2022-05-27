FROM nginx:alpine
COPY --from=build /usr/src/app/dist/DevOpsFront /usr/share/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf

