FROM nginx:alpine
COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=node /DevOpsFront/dist /usr/share/nginx/html


