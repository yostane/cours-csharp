# Cours de C# (C Sharp)

![ci workflow badge](https://github.com/yostane/cours-csharp/actions/workflows/ci.yml/badge.svg)

## Configuration VSCode

- Créer un venv: `python -m venv venv`
- Utiliser le formateur de "markdownlint"
- settings.json

```json
{
  "markdownlint.config": {
    "default": true,
    "MD007": { "indent": 4 }
  },
  "yaml.schemas": {
    "https://squidfunk.github.io/mkdocs-material/schema.json": "mkdocs.yml"
  },
  "yaml.customTags": [
    "!ENV scalar",
    "!ENV sequence",
    "tag:yaml.org,2002:python/name:materialx.emoji.to_svg",
    "tag:yaml.org,2002:python/name:materialx.emoji.twemoji",
    "tag:yaml.org,2002:python/name:pymdownx.superfences.fence_code_format"
  ]
}

```
