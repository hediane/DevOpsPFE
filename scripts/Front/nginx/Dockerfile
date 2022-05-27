FROM nginx:alpine
COPY --from=build dist/DevOpsFront /usr/share/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf

