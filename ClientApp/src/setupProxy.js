const { createProxyMiddleware } = require('http-proxy-middleware');
const { env } = require('process');

const target = 'https://localhost:7253';

const context = [
    "/swagger",
  "/TrainingProgram",
];




module.exports = function(app) {
  const appProxy = createProxyMiddleware(context, {
    proxyTimeout: 10000,
    target: target,
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  });

  app.use(appProxy);
};
