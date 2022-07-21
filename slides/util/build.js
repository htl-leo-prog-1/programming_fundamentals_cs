import { join } from "path";
import pkgEsbuild from "esbuild";
const { build } = pkgEsbuild;
import copy from "recursive-copy";
import replace from "replace-in-file";

(async () => {
  // Copy HTML and Markdown files
  var options = {
    overwrite: true,
    dot: true,
    filter: [
      "*.html",
      "**/*.md",
      "**/*.png",
      "**/*.jpg",
      "**/*.jpeg",
      "**/*.svg",
      "**/*.gif",
    ],
  };
  await copy("src", "dist", options);
  const replaceOptions = {
    files: 'dist/**/*.md',
    from: [/[Ss]tatement(s)?/g, /[Ee]xpression(s)?/g, /[Ss]cope(s)?/g],
    to: (match) => `<span translate="no">&nbsp;${match}&nbsp;</span>`,
  };
  await replace(replaceOptions);

  // Copy favicon-related files
  await copy("favicon", "dist", { overwrite: true });

  // Build JS bundle
  build({
    entryPoints: [join("src", "index.js")],
    bundle: true,
    minify: true,
    target: ["es2020"],
    sourcemap: true,
    outfile: join("dist", "index.js"),
  });

  // Build CSS bundle (includes copying of fonts)
  build({
    entryPoints: [join("src", "index.css")],
    bundle: true,
    minify: true,
    loader: {
      ".eot": "base64",
      ".ttf": "base64",
      ".woff": "base64",
    },
    outfile: join("dist", "index.css"),
  });

  console.log("Built ", new Date().toISOString());
})();
