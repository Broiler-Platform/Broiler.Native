#!/usr/bin/env bash
set -euo pipefail
configuration="${1:-Release}"
dotnet run --project src/tests/Broiler.Native.Tests/Broiler.Native.Tests.csproj -c "$configuration" --no-build
