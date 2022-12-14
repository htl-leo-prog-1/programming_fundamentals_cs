docker run --rm -v `pwd`:/data -w /data  rstropek/pandoc-latex -f markdown \
    --template https://raw.githubusercontent.com/Wandmalfarbe/pandoc-latex-template/v2.0.0/eisvogel.tex \
    -t latex -o ./readme.pdf --lua-filter pagebreak.lua --metadata-file=readme.yaml readme.md

docker run --rm -v `pwd`:/data -w /data  rstropek/pandoc-latex -f markdown \
    --template https://raw.githubusercontent.com/Wandmalfarbe/pandoc-latex-template/v2.0.0/eisvogel.tex \
    -t latex -o ./readme-de.pdf --lua-filter pagebreak.lua --metadata-file=readme-de.yaml readme-de.md
