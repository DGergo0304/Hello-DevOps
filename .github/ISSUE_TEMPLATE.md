---
title: "❌ Teszt megbukott: {{ env.GITHUB_SHA }}"
labels: bug
---

A tesztek megbuktak a legutóbbi push során.

- **Commit:** `{{ env.GITHUB_SHA }}`
- **Branch:** `{{ env.GITHUB_REF }}`
- **Futtatás:** [Link]({{ env.GITHUB_SERVER_URL }}/{{ env.GITHUB_REPOSITORY }}/actions/runs/{{ env.GITHUB_RUN_ID }})