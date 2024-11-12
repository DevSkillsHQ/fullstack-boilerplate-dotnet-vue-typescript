# Frontend Boilerplate Vue 3 / Typescript / Vite

Here comes a Vue3/Typescript/Vite project boilerplate.

Find the source code is under `src/`.

## Available Scripts

In the project directory, you can run:

### `npm start`

Runs the app in development mode.\
Open [http://localhost:4200](http://localhost:4200) to view it in your browser.

The page will automatically reload when you make changes.\
You may also see any lint errors in the console.

### `npm run build`

Builds the app for production to the `dist` folder.\
It correctly bundles Vue in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.\
Your app is ready to be deployed!

### `npm run serve`

Locally preview the production build.

## Learn More

To learn more about Vite, check out the [Vite documentation](https://vitejs.dev/).

To learn more about Vue, check out the [Vue documentation](https://vuejs.org/).

### Vite Configuration

You can customize the Vite configuration in the `vite.config.js` file. For more information, see the [Vite Config Reference](https://vitejs.dev/config/).

### Deployment

For information about deploying your Vite app, check out the [Vite Deployment Guide](https://vitejs.dev/guide/static-deploy.html).

### Performance Optimization

Vite is designed to be fast by default. However, for more advanced performance optimizations, refer to the [Vite Performance Guide](https://vitejs.dev/guide/performance.html).

### Troubleshooting

If you encounter any issues, check the [Vite Troubleshooting Guide](https://vitejs.dev/guide/troubleshooting.html) or the [Vitest Troubleshooting Guide](https://vitest.dev/guide/debugging.html).

This template should help get you started developing with Vue 3 and TypeScript in Vite. The template uses Vue 3 `<script setup>` SFCs, check out the [script setup docs](https://v3.vuejs.org/api/sfc-script-setup.html#sfc-script-setup) to learn more.

### Recommended IDE Setup

- [VS Code](https://code.visualstudio.com/) + [Volar](https://marketplace.visualstudio.com/items?itemName=Vue.volar) (and disable Vetur) + [TypeScript Vue Plugin (Volar)](https://marketplace.visualstudio.com/items?itemName=Vue.vscode-typescript-vue-plugin).

### Type Support For `.vue` Imports in TS

TypeScript cannot handle type information for `.vue` imports by default, so we replace the `tsc` CLI with `vue-tsc` for type checking. In editors, we need [TypeScript Vue Plugin (Volar)](https://marketplace.visualstudio.com/items?itemName=Vue.vscode-typescript-vue-plugin) to make the TypeScript language service aware of `.vue` types.

If the standalone TypeScript plugin doesn't feel fast enough to you, Volar has also implemented a [Take Over Mode](https://github.com/johnsoncodehk/volar/discussions/471#discussioncomment-1361669) that is more performant. You can enable it by the following steps:

1. Disable the built-in TypeScript Extension
   1. Run `Extensions: Show Built-in Extensions` from VSCode's command palette
   2. Find `TypeScript and JavaScript Language Features`, right click and select `Disable (Workspace)`
2. Reload the VSCode window by running `Developer: Reload Window` from the command palette.
